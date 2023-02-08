using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwellSharp
{
    public class SwellApiClient
    {
        public string BaseUri;
        private readonly string _storeId;
        private readonly string _secretKey;

        public SwellApiClient(string baseUri, string storeId, string secretKey)
        {
             BaseUri = baseUri;
            _storeId = storeId;
            _secretKey = secretKey;
        }

        public async Task<T> ExecuteAsync<T>(HttpMethod method, string requestUrl, object data = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + GetEncodedCredentials());
                var requestMessage = new HttpRequestMessage(method, $"{BaseUri}{requestUrl}");
                if (data != null)
                {
                    var json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                var response = await client.SendAsync(requestMessage);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var exception = JsonConvert.DeserializeObject<SwellException>(result);
                    exception.ApiResponse = result;
                    exception.StatusCode = response.StatusCode;
                    throw exception;
                }

                var responseObj = JsonConvert.DeserializeObject<T>(result);
                return responseObj;
            }
        }

        string GetEncodedCredentials() => Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{_storeId}:{_secretKey}"));
    }
}
