using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwellSharp.Dto
{
    public class SwellOrdersQuery : BaseResponse
    {
        [JsonProperty("results")]
        public List<SwellOrder> SwellOrders { get; set; }
    }

    public class SwellOrder
    {
        [JsonProperty("cart_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CartId { get; set; }

        [JsonProperty("draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Draft { get; set; }

        [JsonProperty("test")]
        public bool? Test { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("billing")]
        public Billing Billing { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        [JsonProperty("shipment_rating", NullValueHandling = NullValueHandling.Ignore)]
        public ShipmentRating ShipmentRating { get; set; }

        [JsonProperty("shipment_discount")]
        public long? ShipmentDiscount { get; set; }

        [JsonProperty("schedule")]
        public object Schedule { get; set; }

        [JsonProperty("coupon_code")]
        public string CouponCode { get; set; }

        [JsonProperty("coupon_id")]
        public string CouponId { get; set; }

        [JsonProperty("discounts")]
        public ResultDiscount[] Discounts { get; set; }

        [JsonProperty("taxes")]
        public object Taxes { get; set; }

        [JsonProperty("shipments")]
        public Shipments Shipments { get; set; }

        [JsonProperty("returns")]
        public Returns Returns { get; set; }

        [JsonProperty("refunds")]
        public Refunds Refunds { get; set; }

        [JsonProperty("item_tax_included")]
        public bool? ItemTaxIncluded { get; set; }

        [JsonProperty("shipment_tax")]
        public object ShipmentTax { get; set; }

        [JsonProperty("shipment_tax_included")]
        public bool? ShipmentTaxIncluded { get; set; }

        [JsonProperty("promotion_ids")]
        public object[] PromotionIds { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("account_logged_in")]
        public bool? AccountLoggedIn { get; set; }

        [JsonProperty("account_info_saved")]
        public bool? AccountInfoSaved { get; set; }

        [JsonProperty("account_credit_applied")]
        public object AccountCreditApplied { get; set; }

        [JsonProperty("account_credit_amount")]
        public object AccountCreditAmount { get; set; }

        [JsonProperty("giftcards")]
        public object Giftcards { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("display_currency")]
        public object DisplayCurrency { get; set; }

        [JsonProperty("display_locale")]
        public string DisplayLocale { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("gift")]
        public object Gift { get; set; }

        [JsonProperty("gift_message")]
        public object GiftMessage { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("shipment_delivery")]
        public bool ShipmentDelivery { get; set; }

        [JsonProperty("date_trial_end")]
        public object DateTrialEnd { get; set; }

        [JsonProperty("sub_total")]
        public long SubTotal { get; set; }

        [JsonProperty("shipment_price")]
        public long ShipmentPrice { get; set; }

        [JsonProperty("shipment_total")]
        public long ShipmentTotal { get; set; }

        [JsonProperty("item_tax")]
        public long ItemTax { get; set; }

        [JsonProperty("tax_included_total")]
        public long TaxIncludedTotal { get; set; }

        [JsonProperty("item_discount")]
        public long ItemDiscount { get; set; }

        [JsonProperty("discount_total")]
        public long DiscountTotal { get; set; }

        [JsonProperty("grand_total")]
        public long GrandTotal { get; set; }

        [JsonProperty("item_quantity_returned")]
        public long ItemQuantityReturned { get; set; }

        [JsonProperty("return_item_total")]
        public long ReturnItemTotal { get; set; }

        [JsonProperty("return_item_tax")]
        public long ReturnItemTax { get; set; }

        [JsonProperty("return_item_tax_included")]
        public long ReturnItemTaxIncluded { get; set; }

        [JsonProperty("return_total")]
        public long ReturnTotal { get; set; }

        [JsonProperty("payment_balance")]
        public long PaymentBalance { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("item_quantity_delivered")]
        public long ItemQuantityDelivered { get; set; }

        [JsonProperty("item_quantity_deliverable")]
        public long ItemQuantityDeliverable { get; set; }

        [JsonProperty("delivered")]
        public bool Delivered { get; set; }

        [JsonProperty("item_quantity")]
        public long ItemQuantity { get; set; }

        [JsonProperty("item_quantity_canceled")]
        public long ItemQuantityCanceled { get; set; }

        [JsonProperty("item_quantity_cancelable")]
        public long ItemQuantityCancelable { get; set; }

        [JsonProperty("item_quantity_shipment_deliverable")]
        public long ItemQuantityShipmentDeliverable { get; set; }

        [JsonProperty("item_quantity_returnable")]
        public long ItemQuantityReturnable { get; set; }

        [JsonProperty("item_quantity_invoiced")]
        public long ItemQuantityInvoiced { get; set; }

        [JsonProperty("item_quantity_invoiceable")]
        public long ItemQuantityInvoiceable { get; set; }

        [JsonProperty("item_quantity_credited")]
        public long ItemQuantityCredited { get; set; }

        [JsonProperty("item_quantity_creditable")]
        public long ItemQuantityCreditable { get; set; }

        [JsonProperty("item_shipment_weight")]
        public double ItemShipmentWeight { get; set; }

        [JsonProperty("shipment_tax_included_total")]
        public long ShipmentTaxIncludedTotal { get; set; }

        [JsonProperty("tax_total")]
        public long TaxTotal { get; set; }

        [JsonProperty("giftcard_total")]
        public long GiftcardTotal { get; set; }

        [JsonProperty("guest")]
        public bool Guest { get; set; }

        [JsonProperty("authorized_payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedPaymentId { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("hold")]
        public bool Hold { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_total")]
        public long PaymentTotal { get; set; }

        [JsonProperty("refund_total")]
        public long RefundTotal { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("date_updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateUpdated { get; set; }

        [JsonProperty("payment_marked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PaymentMarked { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subscription_delivery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SubscriptionDelivery { get; set; }

        [JsonProperty("item_quantity_subscription_deliverable", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemQuantitySubscriptionDeliverable { get; set; }

        [JsonProperty("currency_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? CurrencyRate { get; set; }

        [JsonProperty("currency_base", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyBase { get; set; }

        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        [JsonProperty("date_period_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DatePeriodStart { get; set; }

        [JsonProperty("date_period_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DatePeriodEnd { get; set; }

        [JsonProperty("date_payment_retry")]
        public object DatePaymentRetry { get; set; }

        [JsonProperty("payment_error", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentError { get; set; }

        [JsonProperty("payment_retry_resolve", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentRetryResolve { get; set; }

        [JsonProperty("auto_update_account_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdateAccountAddress { get; set; }
    }

    public class Returns
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public List<SwellReturn> Results { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }
    }

    public partial class Refunds
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public RefundsResult[] Results { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }
    }

    public partial class RefundsResult
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("reason")]
        public object Reason { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("subscription_id")]
        public object SubscriptionId { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("account_card_id")]
        public string AccountCardId { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Shipments
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public List<ShipmentsResult> Results { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }
    }

    public class ShipmentsResult
    {
        [JsonProperty("items")]
        public FluffyItem[] Items { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("carrier_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("number")]
        public string ShipmentNumber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; set; }

        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public Destination Destination { get; set; }
    }

    public class FluffyItem
    {
        [JsonProperty("order_item_id")]
        public string OrderItemId { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }
    }

    public class Billing
    {
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

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

        [JsonProperty("use_account", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAccount { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Card Card { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("account_card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountCardId { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }
    }

    public class Card
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("last4")]
        public long Last4 { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("address_check")]
        public string AddressCheck { get; set; }

        [JsonProperty("zip_check")]
        public string ZipCheck { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("date_updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateUpdated { get; set; }
    }

    public class Item
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("options")]
        public object Options { get; set; }

        [JsonProperty("discounts")]
        public object Discounts { get; set; }

        [JsonProperty("discount_each")]
        public long DiscountEach { get; set; }

        [JsonProperty("discount_total")]
        public long DiscountTotal { get; set; }

        [JsonProperty("taxes")]
        public object Taxes { get; set; }

        [JsonProperty("tax_each")]
        public long TaxEach { get; set; }

        [JsonProperty("tax_total")]
        public long TaxTotal { get; set; }

        [JsonProperty("bundle_items")]
        public List<OrderBundleItem> BundleItems { get; set; }

        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shipment_weight")]
        public double? ShipmentWeight { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("quantity_total")]
        public long? QuantityTotal { get; set; }

        [JsonProperty("price_total")]
        public long? PriceTotal { get; set; }

        [JsonProperty("quantity_invoiceable", NullValueHandling = NullValueHandling.Ignore)]
        public long? QuantityInvoiceable { get; set; }

        [JsonProperty("quantity_creditable", NullValueHandling = NullValueHandling.Ignore)]
        public long? QuantityCreditable { get; set; }

        [JsonProperty("quantity_cancelable")]
        public long? QuantityCancelable { get; set; }

        [JsonProperty("quantity_deliverable")]
        public int? QuantityDeliverable { get; set; }

        [JsonProperty("quantity_shipment_deliverable")]
        public int? QuantityShipmentDeliverable { get; set; }

        [JsonProperty("quantity_canceled")]
        public long? QuantityCanceled { get; set; }

        [JsonProperty("quantity_delivered")]
        public long? QuantityDelivered { get; set; }

        [JsonProperty("quantity_returnable")]
        public long? QuantityReturnable { get; set; }

        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        [JsonProperty("orig_price", NullValueHandling = NullValueHandling.Ignore)]
        public long? OrigPrice { get; set; }

        [JsonProperty("recurring_price", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecurringPrice { get; set; }

        [JsonProperty("recurring_price_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecurringPriceTotal { get; set; }

        [JsonProperty("recurring_discount_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecurringDiscountTotal { get; set; }

        [JsonProperty("recurring_discount_each", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecurringDiscountEach { get; set; }

        [JsonProperty("recurring_tax_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecurringTaxTotal { get; set; }

        [JsonProperty("recurring_tax_each", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecurringTaxEach { get; set; }

        [JsonProperty("date_created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateCreated { get; set; }
    }

    public class OrderBundleItem : BundleItem
    {
        [JsonProperty("quantity_total")]
        public long QuantityTotal { get; set; }


        [JsonProperty("quantity_cancelable")]
        public long QuantityCancelable { get; set; }

        [JsonProperty("quantity_deliverable")]
        public long QuantityDeliverable { get; set; }

        [JsonProperty("quantity_shipment_deliverable")]
        public long QuantityShipmentDeliverable { get; set; }

        [JsonProperty("quantity_canceled")]
        public long QuantityCanceled { get; set; }

        [JsonProperty("quantity_delivered")]
        public long QuantityDelivered { get; set; }

        [JsonProperty("quantity_consumed")]
        public long QuantityConsumed { get; set; }
    }

    public class ShipmentRating
    {
        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("services")]
        public ServiceElement[] Services { get; set; }
    }


    public class ResultDiscount
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rule")]
        public object Rule { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ServiceElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }
    }

    public class Shipping
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("account_address_id")]
        public string AccountAddressId { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("service_name")]
        public string ServiceName { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }
    }
}