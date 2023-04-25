using System.Net.Http.Json;

namespace pt_AB_New_TEST.NorthwindCloudApp
{
    public class NorthwindCloudAppService: INorthwindCloudAppService
    {
        private readonly HttpClient _http;

        public NorthwindCloudAppService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Customer>> GetCustomer()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://northwindcloud.azurewebsites.net/api/customers", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Customer>>().ConfigureAwait(false);
            }

            return new List<Customer>();
        }
    }
}