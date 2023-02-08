using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Abp.Collections.Extensions;
using Abp.Extensions;
using SwellSharp.Dto;

namespace SwellSharp
{
    public class SwellProductOrderService
    {
        public readonly SwellApiClient ApiClient;

        public SwellProductOrderService(string storeId, string secretKey)
        {
            ApiClient = new SwellApiClient(SwellConsts.BaseUrl, storeId, secretKey);
        }

        public async Task<List<SwellProduct>> GetSwellProducts(SwellFilter swellFilter, List<string> productIds = null)
        {
            var swellProducts = new List<SwellProduct>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var urlBuilder = new StringBuilder($"{SwellConsts.ProductsUrl}?where[active]={swellFilter.Active}");
            if (swellFilter.DateCreated.HasValue) urlBuilder.Append($"&where[date_created][$gte]={swellFilter.DateCreated}");
            if (!swellFilter.Include.IsNullOrEmpty()) urlBuilder.Append($"&include={swellFilter.Include}");
            if (!swellFilter.Sort.IsNullOrEmpty()) urlBuilder.Append($"&sort={swellFilter.Sort}");
            if (!swellFilter.Search.IsNullOrEmpty()) urlBuilder.Append($"&search={swellFilter.Search}");
            if (!swellFilter.Expand.IsNullOrEmpty()) urlBuilder.Append($"&expand={swellFilter.Expand}");
            if (productIds != null && productIds.Any()) urlBuilder.Append($"&where[id][$in]={productIds.JoinAsString(",")}");

            var url = urlBuilder.ToString();
            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SwellAllProducts>(HttpMethod.Get, url, inputFilter);
                swellProducts.AddRange(response.SwellProducts);
                inputFilter.Page++;

                if (response.SwellProducts.Count < SwellConsts.Limit) break;
            }

            return swellProducts;
        }

        public async Task<List<ProductVariant>> GetAllProductVariants(SwellFilter swellFilter)
        {
            var productVariants = new List<ProductVariant>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var url = $"{SwellConsts.ProductsUrl}?where[active]={swellFilter.Active}";
            if (!swellFilter.Include.IsNullOrEmpty()) url = $"{url}&include={swellFilter.Include}";
            if (!swellFilter.Sort.IsNullOrEmpty()) url = $"{url}&sort={swellFilter.Sort}";
            if (!swellFilter.Search.IsNullOrEmpty()) url = $"{url}&search={swellFilter.Search}";

            while (true)
            {
                var allVariants = await ApiClient.ExecuteAsync<AllVariants>(HttpMethod.Get, url, inputFilter);
                productVariants.AddRange(allVariants.ProductVariants);
                inputFilter.Page++;

                if (allVariants.Count < 250) break;
            }

            return productVariants;
        }

        public async Task<List<SwellCategory>> GetAllCategories(SwellFilter swellFilter)
        {
            var categories = new List<SwellCategory>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var url = $"{SwellConsts.CategoriesUrl}?where[active]={swellFilter.Active}";
            if (!swellFilter.Include.IsNullOrEmpty()) url = $"{url}&include={swellFilter.Include}";
            if (!swellFilter.Sort.IsNullOrEmpty()) url = $"{url}&sort={swellFilter.Sort}";
            if (!swellFilter.Search.IsNullOrEmpty()) url = $"{url}&search={swellFilter.Search}";
            while (true)
            {
                var allCategories = await ApiClient.ExecuteAsync<AllCategories>(HttpMethod.Get, url, inputFilter);
                categories.AddRange(allCategories.SwellCategories);
                inputFilter.Page++;

                if (allCategories.Count < 250) break;
            }

            return categories;
        }

        public async Task<List<SwellAttribute>> GetAllAttributes(SwellFilter swellFilter)
        {
            var attributes = new List<SwellAttribute>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var url = $"{SwellConsts.AttributesUrl}?where[active]={swellFilter.Active}";
            if (!swellFilter.Include.IsNullOrEmpty()) url = $"{url}&include={swellFilter.Include}";
            if (!swellFilter.Sort.IsNullOrEmpty()) url = $"{url}&sort={swellFilter.Sort}";
            if (!swellFilter.Search.IsNullOrEmpty()) url = $"{url}&search={swellFilter.Search}";

            while (true)
            {
                var allAttributes = await ApiClient.ExecuteAsync<AllAttributes>(HttpMethod.Get, url, inputFilter);
                attributes.AddRange(allAttributes.SwellAttributes);
                inputFilter.Page++;

                if (allAttributes.Count < SwellConsts.Limit) break;
            }

            return attributes;
        }

        public async Task<List<SwellOrder>> GetAllSwellOrders(SwellFilter swellFilter)
        {
            var orders = new List<SwellOrder>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var url = $"{SwellConsts.SwellOrdersUrl}?where[date_created][$gte]={swellFilter.DateCreated:yyyy-MM-dd}";
            if (!swellFilter.Include.IsNullOrEmpty()) url = $"{url}&include={swellFilter.Include}";
            if (!swellFilter.Sort.IsNullOrEmpty()) url = $"{url}&sort={swellFilter.Sort}";
            if (!swellFilter.Search.IsNullOrEmpty()) url = $"{url}&search={swellFilter.Search}";
            if (!swellFilter.Expand.IsNullOrEmpty()) url = $"{url}&expand={swellFilter.Expand}";

            while (true)
            {
                var response = await ApiClient.ExecuteAsync<SwellOrdersQuery>(HttpMethod.Get, url, inputFilter);
                orders.AddRange(response.SwellOrders);
                inputFilter.Page++;

                if (orders.Count % (SwellConsts.Limit * 2) == 0) Thread.Sleep(3000);
                if (response.SwellOrders.Count < SwellConsts.Limit) break;
            }

            return orders;
        }

        public async Task<SwellOrder> GetSwellOrder(string orderId)
        {
            var uri = $"{SwellConsts.SwellOrdersUrl}/{orderId}?expand={SwellConsts.OrdersExpand}";
            return await ApiClient.ExecuteAsync<SwellOrder>(HttpMethod.Get, uri);
        }

        public async Task<StockAdjustmentResponse> CreateStockAdjustment(StockAdjustmentRequest request)
        {
            return await ApiClient.ExecuteAsync<StockAdjustmentResponse>(HttpMethod.Post, $"{SwellConsts.StockAdjustmentUrl}", request);
        }

        public async Task<SwellProduct> GetSwellProduct(string productId)
        {
            var uri = $"{SwellConsts.ProductsUrl}/{productId}?expand={SwellConsts.ProductsExpand}";
            return await ApiClient.ExecuteAsync<SwellProduct>(HttpMethod.Get, uri);
        }

        public async Task<SwellVariant> GetSwellProductVariant(string variantId)
        {
            return await ApiClient.ExecuteAsync<SwellVariant>(HttpMethod.Get, $"{SwellConsts.ProductVariantUrl}/{variantId}");
        }
    }
}