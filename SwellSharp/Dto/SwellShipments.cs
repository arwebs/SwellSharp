using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class AllShipments : BaseResponse
    {
        [JsonProperty("results")]
        public List<SwellShipment> Shipments { get; set; }

        [JsonProperty("pages")]
        public Dictionary<string, Page> Pages { get; set; }
    }

    public class Page
    {
        [JsonProperty("start")]
        public long? Start { get; set; }

        [JsonProperty("end")]
        public long? End { get; set; }
    }

    public class SwellShipment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("items")]
        public List<ShipmentItem> Items { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset? DateUpdated { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }    

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("carrier_name")]
        public string CarrierName { get; set; }

        [JsonProperty("number")]
        public string ShipmentNumber { get; set; }
    }

    public class Destination
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ShipmentItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_item_id")]
        public string OrderItemId { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("bundle_item_id")]
        public string BundleItemId { get; set; }
    }
}