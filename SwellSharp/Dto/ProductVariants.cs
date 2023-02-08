using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class AllVariants : BaseResponse
    {
        [JsonProperty("results")]
        public List<ProductVariant> ProductVariants { get; set; }
    }

    public class ProductVariant
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Price { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset? DateUpdated { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("option_value_ids", NullValueHandling = NullValueHandling.Ignore)]
        public object[] OptionValueIds { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public object Attributes { get; set; }

        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Prices { get; set; }

        [JsonProperty("purchase_options", NullValueHandling = NullValueHandling.Ignore)]
        public object PurchaseOptions { get; set; }

        [JsonProperty("sale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sale { get; set; }

        [JsonProperty("sale_price")]
        public long? SalePrice { get; set; }

        [JsonProperty("stock_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? StockLevel { get; set; }
    }

    public class StockAdjustmentRequest
    {
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
    public class StockAdjustmentResponse
    {
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("prev_id")]
        public string PrevId { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("reason_message")]
        public object ReasonMessage { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}