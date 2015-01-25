﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripePageable
    {
        [JsonProperty("object")]
        public string Object { get; set; }
     
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}
