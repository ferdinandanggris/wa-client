using Newtonsoft.Json;

namespace wa_client.Models
{
    public class BillingQuota
    {
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("quota_limit")]
        public int QuotaLimit { get; set; }

        [JsonProperty("quota_used")]
        public int QuotaUsed { get; set; }

        public int Remaining { get; set; }
    }

    public class BillingCostSummaryItem
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("conversation_category")]
        public string ConversationCategory { get; set; }

        [JsonProperty("total_messages")]
        public int TotalMessages { get; set; }

        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }
    }
}
