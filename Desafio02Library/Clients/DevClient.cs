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

        public static async Task<Dev?> AddDev(Dev dev)
        {
            var keyValuePairs = new List<KeyValuePair<string, string>>();
            keyValuePairs.Add(new KeyValuePair<string, string>("name", dev.Nome));
            keyValuePairs.Add(new KeyValuePair<string, string>("avatar", dev.Avatar));
            keyValuePairs.Add(new KeyValuePair<string, string>("squad", dev.Squad));
            keyValuePairs.Add(new KeyValuePair<string, string>("login", dev.Login));
            keyValuePairs.Add(new KeyValuePair<string, string>("email", dev.Email));

            var req = new HttpRequestMessage(HttpMethod.Post, _baseUri) { Content = new FormUrlEncodedContent(keyValuePairs) };

            var response = _client.SendAsync(req);
            response.Wait();
            response.Result.EnsureSuccessStatusCode();
            var json = await response.Result.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dev>(json);
        }

        public static async Task<Dev?> UpdateDev(Dev dev)
        {
            var keyValuePairs = new List<KeyValuePair<string, string>>();
            keyValuePairs.Add(new KeyValuePair<string, string>("name", dev.Nome));
            keyValuePairs.Add(new KeyValuePair<string, string>("avatar", dev.Avatar));
            keyValuePairs.Add(new KeyValuePair<string, string>("squad", dev.Squad));
            keyValuePairs.Add(new KeyValuePair<string, string>("login", dev.Login));
            keyValuePairs.Add(new KeyValuePair<string, string>("email", dev.Email));

            var uri = _baseUri + "/" + dev.Id;
            var req = new HttpRequestMessage(HttpMethod.Put, uri) { Content = new FormUrlEncodedContent(keyValuePairs) };

            var response = _client.SendAsync(req);
            response.Wait();
            response.Result.EnsureSuccessStatusCode();
            var json = await response.Result.Content.ReadAsStringAsync();

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dev>(json);
        }
    }
}
