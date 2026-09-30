using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Api_Lab
{
    public class ApiClient
    {
        private readonly HttpClient _adressHttp;

        public ApiClient(string baseUrl)
        {
            _adressHttp = new HttpClient { BaseAddress = new Uri(baseUrl) };
        }

        public async Task<SomeData> FinddAsync(string methodName)
        {
            var response = await _adressHttp.GetAsync(methodName);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadFromJsonAsync<SomeData>();
            return data;
        }
    }
}