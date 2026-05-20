using System;

namespace wa_client.Helpers
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string ToSafeString(this object value)
        {
            return value?.ToString() ?? "";
        }
    }
}