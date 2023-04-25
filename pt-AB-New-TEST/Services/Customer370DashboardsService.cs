using System.Net.Http.Json;

namespace pt_AB_New_TEST.Customer370Dashboards
{
    public class Customer370DashboardsService: ICustomer370DashboardsService
    {
        private readonly HttpClient _http;

        public Customer370DashboardsService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<DashboardsType>> GetDashboards()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/9e370bb8-61ed-419c-00ab-08da188ec9ab", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<DashboardsType>>().ConfigureAwait(false);
            }

            return new List<DashboardsType>();
        }
    }
}