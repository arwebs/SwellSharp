namespace SwellSharp
{
    public static class SwellConsts
    {
        public const string BaseUrl = "https://api.swell.store";
        public const int Limit = 250;

        public const string ProductsUrl = "/products";
        public const string SwellOrdersUrl = "/orders";
        public const string StockAdjustmentUrl = "/products:stock";
        public const string ProductVariantUrl = "/products:variants";
        public const string CategoriesUrl = "/categories";
        public const string AttributesUrl = "/attributes";
        public const string ShipmentsUrl = "/shipments";
        public const string ReturnsUrl = "/returns";
        public const string WebhooksUrl = "/:webhooks";
        public const string OrdersExpand = "items,shipments,returns";
        public const string ProductsExpand = "variants,bundle_items";
        
        public static List<string> ProductEvents = new List<string>()
        {
            "product.created", "product.updated", "product.variant.created", "product.variant.updated","product.stock_adjusted"
        };

        public static List<string> OrderEvents = new List<string>()
        {
            "order.created", "order.updated", "order.refunded", "order.paid","order.refunded","order.delivered"
        };
    }
}