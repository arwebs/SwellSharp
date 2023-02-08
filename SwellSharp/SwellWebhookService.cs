using SwellSharp.Dto;

namespace SwellSharp
{
    public class SwellWebhookService
    {
        public readonly SwellApiClient ApiClient;

        public SwellWebhookService(string storeId, string secretKey)
        {
            ApiClient = new SwellApiClient(SwellConsts.BaseUrl, storeId, secretKey);
        }

        public async Task<WebhooksQueryResponse> GetAllSwellWebhooks()
        {
            var inputFilter = new RequestFilter();
            return await ApiClient.ExecuteAsync<WebhooksQueryResponse>(HttpMethod.Get, $"{SwellConsts.WebhooksUrl}?where[enabled]=true", inputFilter);
        }

        public async Task<SwellWebhook> CreateSwellWebhook(CreateWebhook input) =>
            await ApiClient.ExecuteAsync<SwellWebhook>(HttpMethod.Post, SwellConsts.WebhooksUrl, input);

        public async Task<SwellWebhook> UpdateSwellWebhook(SwellWebhook input) =>
            await ApiClient.ExecuteAsync<SwellWebhook>(HttpMethod.Post, $"{SwellConsts.WebhooksUrl}/{input.Id}", input);

        public async Task<SwellWebhook> DeleteSwellWebhook(string webhookId) =>
            await ApiClient.ExecuteAsync<SwellWebhook>(HttpMethod.Delete, $"{SwellConsts.WebhooksUrl}/{webhookId}");
    }
}