using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Client
{
    public class DevClient
    {
        private static readonly string _baseUri = "https://61a170e06c3b400017e69d00.mockapi.io/DevTest/Dev";

        private static readonly HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(_baseUri),
            Timeout = TimeSpan.FromSeconds(10)  
        };

        private DevClient() { }

        public static async Task<List<Dev>?> GetAllDevelopersAsync()
        {
            var response = _client.GetAsync(string.Empty);
            response.Wait();
            response.Result.EnsureSuccessStatusCode();
            var json = await response.Result.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dev>>(json);
        }

        public static async Task<Dev?> GetDevelopersByIdAsync(int id)
        {
            var response = _client.GetAsync("/" + id);
            response.Wait();
            response.Result.EnsureSuccessStatusCode();
            var json = await response.Result.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dev>(json);
        }
    }
}
