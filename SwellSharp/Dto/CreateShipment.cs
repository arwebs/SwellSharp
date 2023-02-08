using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class SwellCreateShipment : SwellShipment
    {
    }

    public class SwellUpdateShipment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("items")]
        public List<ShipmentItem> Items { get; set; }

        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }
    }
}
