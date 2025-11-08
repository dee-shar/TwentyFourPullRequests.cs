using System.Net.Http;

namespace TwentyFourPullRequestsApi
{
    public class TwentyFourPullRequests
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://24pullrequests.com";
        public TwentyFourPullRequests()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetUsers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/users.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetProjects()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/projects.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMeta()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/pull_requests/meta.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPullRequests()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/pull_requests.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetOrganisations()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/organisations.json");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
