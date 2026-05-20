using wa_client.Models;

namespace wa_client.Services
{
    public class AuthService
    {
        private static AuthService _instance;
        private static readonly object _lock = new object();

        private string _token;
        private UserData _currentUser;

        public static AuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new AuthService();
                        }
                    }
                }
                return _instance;
            }
        }

        public bool IsLoggedIn => !string.IsNullOrEmpty(_token);
        public string Token => _token;
        public UserData CurrentUser => _currentUser;

        public void SetToken(string token)
        {
            _token = token;
            ApiClient.Instance.SetToken(token);
        }

        public void SetCurrentUser(UserData user)
        {
            _currentUser = user;
        }

        public void Logout()
        {
            _token = null;
            _currentUser = null;
            ApiClient.Instance.ClearToken();
        }

        public ApiResponse<LoginResponse> Login(string email, string password)
        {
            var request = new LoginRequest
            {
                Email = email,
                Password = password
            };

            var response = ApiClient.Instance.Post<LoginResponse>("/api/v1/auth/login", request);

            if (response.Success && response.Data != null)
            {
                SetToken(response.Data.Token);
                SetCurrentUser(response.Data.User);
            }

            return response;
        }
    }
}