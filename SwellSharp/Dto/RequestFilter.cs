using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class RequestFilter
    {
        [JsonProperty("page")] public int Page { get; set; } = 1;
        [JsonProperty("limit")] public int Limit { get; set; } = 250;
    }

    public class SwellFilter
    {
        [JsonProperty("include")]
        public string Include { get; set; }
        [JsonProperty("search")]
        public string Search { get; set; }
        [JsonProperty("sort")]
        public string Sort { get; set; }
        [JsonProperty("active")] public bool Active { get; set; } = true;

        [JsonProperty("dateCreated")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("expand")]
        public string Expand { get; set; }
    }
}