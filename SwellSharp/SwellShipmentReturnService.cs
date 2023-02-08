using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Abp.Extensions;
using SwellSharp.Dto;

namespace SwellSharp
{
    public class SwellShipmentReturnService
    {
        public readonly SwellApiClient ApiClient;
        public SwellShipmentReturnService(string storeId, string secretKey)
        {
            ApiClient = new SwellApiClient(SwellConsts.BaseUrl, storeId, secretKey);
        }

        public async Task<List<SwellShipment>> GetAllSwellShipments(SwellFilter swellFilter)
        {
            var shipments = new List<SwellShipment>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var url = $"{SwellConsts.ShipmentsUrl}?";
            if (swellFilter.DateCreated.HasValue) url = $"{url}&where[date_created][$gte]={swellFilter.DateCreated}";
            if (!swellFilter.Include.IsNullOrEmpty()) url = $"{url}&include={swellFilter.Include}";
            if (!swellFilter.Sort.IsNullOrEmpty()) url = $"{url}&sort={swellFilter.Sort}";
            if (!swellFilter.Search.IsNullOrEmpty()) url = $"{url}&search={swellFilter.Search}";
            if (!swellFilter.Expand.IsNullOrEmpty()) url = $"{url}&expand={swellFilter.Expand}";

            while (true)
            {
                var response = await ApiClient.ExecuteAsync<AllShipments>(HttpMethod.Get, url, inputFilter);
                shipments.AddRange(response.Shipments);
                inputFilter.Page++;

                if (response.Count < inputFilter.Limit) break;
            }
            return shipments;
        }

        public async Task<List<SwellReturn>> GetAllSwellReturns(SwellFilter swellFilter)
        {
            var returns = new List<SwellReturn>();
            var inputFilter = new RequestFilter { Page = 1, Limit = SwellConsts.Limit };

            var url = $"{SwellConsts.ReturnsUrl}?";
            if (swellFilter.DateCreated.HasValue) url = $"{url}&where[date_created][$gte]={swellFilter.DateCreated}";
            if (!swellFilter.Include.IsNullOrEmpty()) url = $"{url}&include={swellFilter.Include}";
            if (!swellFilter.Sort.IsNullOrEmpty()) url = $"{url}&sort={swellFilter.Sort}";
            if (!swellFilter.Search.IsNullOrEmpty()) url = $"{url}&search={swellFilter.Search}";
            if (!swellFilter.Expand.IsNullOrEmpty()) url = $"{url}&expand={swellFilter.Expand}";

            while (true)
            {
                var allReturns = await ApiClient.ExecuteAsync<AllReturns>(HttpMethod.Get, url, inputFilter);
                returns.AddRange(allReturns.Returns);
                inputFilter.Page++;

                if (allReturns.Count < inputFilter.Limit) break;
            }

            return returns;
        }

        public async Task<SwellShipment> GetShipment(string shipmentId) =>
            await ApiClient.ExecuteAsync<SwellShipment>(HttpMethod.Get, $"{SwellConsts.ShipmentsUrl}/{shipmentId}");

        public async Task<SwellShipment> CreateSwellShipment(SwellCreateShipment input) =>
            await ApiClient.ExecuteAsync<SwellShipment>(HttpMethod.Post, SwellConsts.ShipmentsUrl, input);

        public async Task<SwellShipment> UpdateSwellShipment(SwellUpdateShipment input) =>
            await ApiClient.ExecuteAsync<SwellShipment>(HttpMethod.Put, SwellConsts.ShipmentsUrl, input);

        public async Task<SwellReturn> GetReturn(string returnId) =>
            await ApiClient.ExecuteAsync<SwellReturn>(HttpMethod.Get, $"{SwellConsts.ReturnsUrl}/{returnId}");

        public async Task<SwellReturn> CreateSwellReturn(CreateSwellReturn input) =>
            await ApiClient.ExecuteAsync<SwellReturn>(HttpMethod.Post, SwellConsts.ReturnsUrl, input);
    }
}