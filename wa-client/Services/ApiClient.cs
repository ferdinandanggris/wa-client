using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace wa_client.Services
{
    public class ApiClient
    {
        private static ApiClient _instance;
        private static readonly object _lock = new object();

        private readonly HttpClient _httpClient;
        private string _baseUrl;

        public static ApiClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ApiClient();
                        }
                    }
                }
                return _instance;
            }
        }

        private ApiClient()
        {
            _httpClient = new HttpClient();
            _baseUrl = System.Configuration.ConfigurationSettings.AppSettings["ApiBaseUrl"] ?? "http://localhost:9090";
        }

        public void SetBaseUrl(string url)
        {
            _baseUrl = url;
        }

        public void SetToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public void ClearToken()
        {
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public string BaseUrl => _baseUrl;

        public ApiResponse<T> Get<T>(string endpoint)
        {
            return Execute<T>(() => _httpClient.GetAsync(_baseUrl + endpoint).Result);
        }

        public ApiResponse<T> Post<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            return Execute<T>(() => _httpClient.PostAsync(_baseUrl + endpoint, content).Result);
        }

        public ApiResponse<T> Put<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            return Execute<T>(() => _httpClient.PutAsync(_baseUrl + endpoint, content).Result);
        }

        public ApiResponse<T> Delete<T>(string endpoint)
        {
            return Execute<T>(() => _httpClient.DeleteAsync(_baseUrl + endpoint).Result);
        }

        private ApiResponse<T> Execute<T>(Func<HttpResponseMessage> action)
        {
            try
            {
                var response = action();
                var body = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var result = JsonConvert.DeserializeObject<ApiResponseWrapper<T>>(body);
                        if (result != null && result.Ok)
                        {
                            return new ApiResponse<T> { Success = true, Data = result.Data };
                        }
                        else if (result != null && result.Error != null)
                        {
                            return new ApiResponse<T> 
                            { 
                                Success = false, 
                                ErrorMessage = result.Error.Message 
                            };
                        }
                        return new ApiResponse<T> { Success = false, ErrorMessage = "Unknown error — response: " + body };
                    }
                    catch (JsonException jex)
                    {
                        return new ApiResponse<T> { Success = false, ErrorMessage = jex.Message + " — body: " + body };
                    }
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ApiErrorResponse>(body);
                    return new ApiResponse<T> 
                    { 
                        Success = false, 
                        ErrorMessage = error?.Error?.Message ?? $"HTTP {response.StatusCode}: {body}" 
                    };
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<T> { Success = false, ErrorMessage = ex.Message };
            }
        }
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ApiResponseWrapper<T>
    {
        public T Data { get; set; }
        public bool Ok { get; set; }
        public ApiError Error { get; set; }
    }

    public class ApiErrorResponse
    {
        public bool Ok { get; set; }
        public ApiError Error { get; set; }
    }

    public class ApiError
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}