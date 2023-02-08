using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public  class CreateSwellReturn
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("items")]
        public List<CreateReturnItem> Items { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public  class CreateReturnItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_item_id")]
        public string OrderItemId { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("quantity_received")]
        public long? QuantityReceived { get; set; }

        [JsonProperty("quantity_receivable")]
        public long? QuantityReceivable { get; set; }

        [JsonProperty("quantity_restocked")]
        public long? QuantityRestocked { get; set; }

        [JsonProperty("quantity_restockable")]
        public long? QuantityRestockable { get; set; }
    }
}