using Newtonsoft.Json;

namespace Desafio02Library
{
    public class Dev
    {
        [JsonProperty("id")]
        public int Id { get; set; } = 0;

        [JsonProperty("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonProperty("createdAt")]
        public DateTime DataDeCriacao { get; set; } = DateTime.MinValue;

        [JsonProperty("avatar")]
        public string Avatar { get; set; } = string.Empty;

        [JsonProperty("squad")]
        public string Squad { get; set; } = string.Empty;

        [JsonProperty("login")]
        public string Login { get; set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; set; } = string.Empty;
    }
}