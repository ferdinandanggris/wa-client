using System;

namespace wa_client.Models
{
    public class User
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public LastLoginAt LastLoginAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool IsDirty { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class LastLoginAt
    {
        public DateTime Time { get; set; }
        public bool Valid { get; set; }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        public string Token { get; set; }
        public string ExpiresAt { get; set; }
        public UserData User { get; set; }
    }

    public class UserData
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string CompanyId { get; set; }
        public bool IsActive { get; set; }
        public LastLoginAt LastLoginAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }

    public class ApiListResponse<T>
    {
        public T Data { get; set; }
        public bool Ok { get; set; }
    }
}