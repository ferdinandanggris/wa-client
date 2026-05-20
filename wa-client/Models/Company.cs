using System;

namespace wa_client.Models
{
    public class Company
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public NullString PhoneNumber { get; set; }
        public NullString Address { get; set; }
        public bool IsActive { get; set; }
        public int QuotaLimit { get; set; }
        public int QuotaUsed { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public bool IsDirty { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class NullString
    {
        public string String { get; set; }
        public bool Valid { get; set; }
    }
}