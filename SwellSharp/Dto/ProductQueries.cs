using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class SwellAllProducts : BaseResponse
    {
        [JsonProperty("results")]
        public List<SwellProduct> SwellProducts { get; set; }
    }

    public class SwellProduct
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("purchase_options")]
        public PurplePurchaseOptions PurchaseOptions { get; set; }

        [JsonProperty("variable")]
        public bool Variable { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("bundle_items")] public List<BundleItem> BundleItems { get; set; } = new List<BundleItem>();

        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        [JsonProperty("bundle")]
        public bool? Bundle { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("stock_tracking")]
        public bool StockTracking { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("hidden_on_product_list")]
        public bool HiddenOnProductList { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("sale", NullValueHandling = NullValueHandling.Ignore)]
        public bool Sale { get; set; }

        [JsonProperty("sale_price")]
        public long? SalePrice { get; set; }

        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Prices { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("stock_status")]
        public string StockStatus { get; set; }

        [JsonProperty("date_updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateUpdated { get; set; }

        [JsonProperty("stock_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? StockLevel { get; set; }

        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dimensions { get; set; }

        [JsonProperty("shipment_dimensions")]
        public ShipmentDimensions ShipmentDimensions { get; set; }

        [JsonProperty("shipment_package_quantity")]
        public long? ShipmentPackageQuantity { get; set; }

        [JsonProperty("shipment_prices", NullValueHandling = NullValueHandling.Ignore)]
        public object[] ShipmentPrices { get; set; }

        [JsonProperty("shipment_weight")]
        public double? ShipmentWeight { get; set; }

        [JsonProperty("stock_purchasable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StockPurchasable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("variants")]
        public Variants Variants { get; set; }

        [JsonProperty("popularity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Popularity { get; set; }

        [JsonProperty("virtual", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Virtual { get; set; }

        [JsonProperty("page_title", NullValueHandling = NullValueHandling.Ignore)]
        public string PageTitle { get; set; }

        [JsonProperty("page_description", NullValueHandling = NullValueHandling.Ignore)]
        public string PageDescription { get; set; }

        [JsonProperty("scent_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ScentDescription { get; set; }

        [JsonProperty("container_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerDescription { get; set; }

        [JsonProperty("select_scent", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectScent { get; set; }

        [JsonProperty("select_container", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectContainer { get; set; }

        [JsonProperty("select_plan", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectPlan { get; set; }

        [JsonProperty("selected_scent", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedScent { get; set; }

        [JsonProperty("selected_container", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedContainer { get; set; }

        [JsonProperty("selected_plan", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedPlan { get; set; }

        [JsonProperty("skip_scent_title", NullValueHandling = NullValueHandling.Ignore)]
        public string SkipScentTitle { get; set; }

        [JsonProperty("skip_scent_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SkipScentDescription { get; set; }

        [JsonProperty("subscribe_plan_title", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscribePlanTitle { get; set; }

        [JsonProperty("subscribe_plan_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscribePlanDescription { get; set; }

        [JsonProperty("one_time_plan_title", NullValueHandling = NullValueHandling.Ignore)]
        public string OneTimePlanTitle { get; set; }

        [JsonProperty("one_time_plan_description", NullValueHandling = NullValueHandling.Ignore)]
        public string OneTimePlanDescription { get; set; }

        [JsonProperty("add_to_cart_button_label", NullValueHandling = NullValueHandling.Ignore)]
        public string AddToCartButtonLabel { get; set; }

        [JsonProperty("plan_description", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanDescription { get; set; }

        [JsonProperty("how_subscription_work_title", NullValueHandling = NullValueHandling.Ignore)]
        public string HowSubscriptionWorkTitle { get; set; }

        [JsonProperty("how_subscription_work_body", NullValueHandling = NullValueHandling.Ignore)]
        public string HowSubscriptionWorkBody { get; set; }

        [JsonProperty("select_frequency_label", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectFrequencyLabel { get; set; }

        [JsonProperty("select_quantity_label", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectQuantityLabel { get; set; }

        [JsonProperty("frequency_option_label", NullValueHandling = NullValueHandling.Ignore)]
        public string FrequencyOptionLabel { get; set; }

        [JsonProperty("quantity_option_label", NullValueHandling = NullValueHandling.Ignore)]
        public string QuantityOptionLabel { get; set; }

        [JsonProperty("category_index", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryIndex CategoryIndex { get; set; }
    }

    public class ShipmentDimensions
    {
        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class PurplePurchaseOptions
    {
        [JsonProperty("standard", NullValueHandling = NullValueHandling.Ignore)]
        public Standard Standard { get; set; }

        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Subscription Subscription { get; set; }
    }

    public class Variant
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("price")]
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

        [JsonProperty("stock_level")]
        public long? StockLevel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BundleItem
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("options")]
        public List<BundleItemOption> Options { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("variable")]
        public string Variable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("orig_price")]
        public long OrigPrice { get; set; }

        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        [JsonProperty("stock_tracking")]
        public bool StockTracking { get; set; }

        [JsonProperty("shipment_weight")]
        public double ShipmentWeight { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }
    }

    public class BundleItemOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("variant")]
        public bool Variant { get; set; }

        [JsonProperty("value_id")]
        public string ValueId { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("attribute_1", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Attribute1 { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Size { get; set; }

        [JsonProperty("this_is_an_option", NullValueHandling = NullValueHandling.Ignore)]
        public object[] ThisIsAnOption { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Value { get; set; }
    }

    public class CategoryIndex
    {
        [JsonProperty("sort")]
        public Dictionary<string, long> Sort { get; set; }

        [JsonProperty("id")]
        public string[] Id { get; set; }
    }

    public class Content
    {
        [JsonProperty("product_highlights")]
        public ProductHighlight[] ProductHighlights { get; set; }

        [JsonProperty("expandable_details")]
        public ExpandableDetail[] ExpandableDetails { get; set; }

        [JsonProperty("membership_perks", NullValueHandling = NullValueHandling.Ignore)]
        public object[] MembershipPerks { get; set; }

        [JsonProperty("customer_group")]
        public object CustomerGroup { get; set; }
    }

    public class ExpandableDetail
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ProductHighlight
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("custom_icon")]
        public CustomIcon CustomIcon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CustomIcon
    {
        [JsonProperty("file")]
        public File File { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("length")]
        public long? Length { get; set; }

        [JsonProperty("content_type")]
        public object ContentType { get; set; }

        [JsonProperty("md5")]
        public object Md5 { get; set; }
    }

    public class File
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date_uploaded")]
        public DateTimeOffset? DateUploaded { get; set; }

        [JsonProperty("length")]
        public long? Length { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content_type")]
        public object ContentType { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long? Width { get; set; }

        [JsonProperty("height")]
        public long? Height { get; set; }

        [JsonProperty("uploaded_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UploadedUrl { get; set; }
    }

    public class CrossSell
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("discount_amount")]
        public double? DiscountAmount { get; set; }

        [JsonProperty("discount_percent")]
        public long? DiscountPercent { get; set; }
    }

    public class CustomNamespace143
    {
        [JsonProperty("custom_namespace2")]
        public string CustomNamespace2 { get; set; }
    }

    public class Horizon
    {
        [JsonProperty("product_highlights")]
        public ProductHighlight[] ProductHighlights { get; set; }

        [JsonProperty("whateveeeer")]
        public string Whateveeeer { get; set; }
    }

    public class Image
    {
        [JsonProperty("file")]
        public File File { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Option
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("values")]
        public Value[] Values { get; set; }

        [JsonProperty("variant")]
        public bool Variant { get; set; }

        [JsonProperty("input_type", NullValueHandling = NullValueHandling.Ignore)]
        public object InputType { get; set; }

        [JsonProperty("required")]
        public bool? OptionRequired { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("attribute_id")]
        public object AttributeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }
    }

    public class Value
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("shipment_weight")]
        public object ShipmentWeight { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }
    }

    public class PurchaseOptions
    {
        [JsonProperty("standard")]
        public Standard Standard { get; set; }

        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Subscription Subscription { get; set; }
    }

    public class Standard
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("sale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sale { get; set; }

        [JsonProperty("sale_price")]
        public double? SalePrice { get; set; }

        [JsonProperty("prices")]
        public object[] Prices { get; set; }
    }

    public class Subscription
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("plans")]
        public Plan[] Plans { get; set; }
    }

    public class Variants
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public List<VariantsResult> Results { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }
    }

    public class VariantsResult
    {
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("option_value_ids")]
        public string[] OptionValueIds { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset DateUpdated { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("attributes")]
        public Sort Attributes { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("prices")]
        public object[] Prices { get; set; }

        [JsonProperty("purchase_options")]
        public FluffyPurchaseOptions PurchaseOptions { get; set; }

        [JsonProperty("sale")]
        public bool Sale { get; set; }

        [JsonProperty("sale_price")]
        public long SalePrice { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("stock_level")]
        public int StockLevel { get; set; }

        [JsonProperty("stock_tracking")]
        public bool StockTracking { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FluffyPurchaseOptions
    {
        [JsonProperty("standard")]
        public Standard Standard { get; set; }
    }

    public class Sort
    {
    }

    public class Plan
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("billing_schedule")]
        public BillingSchedule BillingSchedule { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }
    }

    public class BillingSchedule
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }

        [JsonProperty("limit")]
        public object Limit { get; set; }

        [JsonProperty("trial_days")]
        public long? TrialDays { get; set; }
    }

    public class UpSell
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }
    }

    public class SwellVariant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset DateUpdated { get; set; }
    }
}