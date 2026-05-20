using System;
using Newtonsoft.Json;

namespace wa_client.Models
{
    public class PhoneNumber
    {
        public string Id { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumberVal { get; set; }

        [JsonProperty("phone_number_id")]
        public string PhoneNumberId { get; set; }

        public bool IsActive { get; set; }

        [JsonProperty("last_sync_pricing")]
        public long LastSyncPricing { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public bool IsDirty { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class PhoneNumberProfile
    {
        public string About { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string[] Websites { get; set; }
        public string Vertical { get; set; }
    }
}