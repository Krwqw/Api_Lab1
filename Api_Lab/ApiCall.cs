using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
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

        public async Task<List<SomeData>> FinddAsync(string fieldName, string value)
        {
            var url = $"?{fieldName}={Uri.EscapeDataString(value)}";

            var response = await _adressHttp.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadFromJsonAsync<List<SomeData>>();
            return data ?? new List<SomeData>();
        } 
    }
     
}
