using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class CreateWebhook
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        [JsonProperty("enabled")] public bool? Enabled { get; set; } = true;
    }
}