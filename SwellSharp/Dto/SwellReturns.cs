using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class AllReturns : BaseResponse
    {
        [JsonProperty("results")]
        public SwellReturn[] Returns { get; set; }

        [JsonProperty("pages")]
        public Dictionary<string, Page> Pages { get; set; }
    }

    public class SwellReturn
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("shipment_total")]
        public double? ShipmentTotal { get; set; }

        [JsonProperty("restock_fee")]
        public string RestockFee { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("item_quantity_received")]
        public long? ItemQuantityReceived { get; set; }

        [JsonProperty("item_quantity_receivable")]
        public long? ItemQuantityReceivable { get; set; }

        [JsonProperty("item_quantity_restocked")]
        public long? ItemQuantityRestocked { get; set; }

        [JsonProperty("item_quantity_restockable")]
        public long? ItemQuantityRestockable { get; set; }

        [JsonProperty("received")]
        public bool Received { get; set; }

        [JsonProperty("shipment_tax")]
        public long? ShipmentTax { get; set; }

        [JsonProperty("credit_total")]
        public long? CreditTotal { get; set; }

        [JsonProperty("credit_tax")]
        public long? CreditTax { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ReturnItem
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("order_item_id")]
        public string OrderItemId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("quantity_restocked")]
        public object QuantityRestocked { get; set; }

        [JsonProperty("quantity_received")]
        public long QuantityReceived { get; set; }

        [JsonProperty("quantity_receivable")]
        public long QuantityReceivable { get; set; }

        [JsonProperty("quantity_restockable")]
        public long QuantityRestockable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Origin
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
}