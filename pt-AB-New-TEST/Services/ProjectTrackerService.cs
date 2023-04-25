using System.Net.Http.Json;

namespace pt_AB_New_TEST.ProjectTracker
{
    public class ProjectTrackerService: IProjectTrackerService
    {
        private readonly HttpClient _http;

        public ProjectTrackerService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<sp_Select_ProjectsResult>> Getsp_Select_ProjectsResult()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://projecttracker2023apiapp.azurewebsites.net/projects", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<sp_Select_ProjectsResult>>().ConfigureAwait(false);
            }

            return new List<sp_Select_ProjectsResult>();
        }
    }
}