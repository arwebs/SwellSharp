using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class BaseResponse
    {
        [JsonProperty("count")]
        public long? Count { get; set; }

        [JsonProperty("page")]
        public long? Page { get; set; }
    }
}