using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class AllCategories : BaseResponse
    {
        [JsonProperty("results")]
        public List<SwellCategory> SwellCategories { get; set; }
    }

    public class SwellCategory
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("sorting")]
        public object Sorting { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("top_id")]
        public object TopId { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset DateUpdated { get; set; }

        [JsonProperty("sort")]
        public long Sort { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("demo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Demo { get; set; }
    }
}