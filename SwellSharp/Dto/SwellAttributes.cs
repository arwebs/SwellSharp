using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class AllAttributes : BaseResponse
    {
        [JsonProperty("results")]
        public List<SwellAttribute> SwellAttributes { get; set; }
    }

    public class SwellAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("variant", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Variant { get; set; }

        [JsonProperty("filterable")]
        public bool Filterable { get; set; }

        [JsonProperty("searchable")]
        public bool Searchable { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("localized")]
        public bool Localized { get; set; }

        [JsonProperty("required")]
        public bool ResultRequired { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date_updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateUpdated { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Default { get; set; }
    }
}