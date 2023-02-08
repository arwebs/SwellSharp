using Newtonsoft.Json;
namespace SwellSharp.Dto
{
    public class WebhooksQueryResponse : BaseResponse
    {
        [JsonProperty("results")]
        public List<SwellWebhook> Webhooks { get; set; }
    }

    public class SwellWebhook
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("date_final_attempt")]
        public DateTimeOffset? DateFinalAttempt { get; set; }

        [JsonProperty("date_scheduled")]
        public DateTimeOffset? DateScheduled { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset? DateUpdated { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}