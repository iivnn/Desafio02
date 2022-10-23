using Newtonsoft.Json;

namespace Desafio02Library
{
    public class Dev : ICloneable
    {
        [JsonProperty("id")]
        public int? Id { get; set; } = null;

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

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void SetAvatar(int number)
        {
            Avatar = $"https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/{number}.jpg";
        }

        #region Validações

        public bool IsNomeValid(out string message)
        {
            message = string.Empty;
            if (Nome.Length == 0)
            {
                message = "Nome é requerido.";
                return false;
            }
            return true;
        }

        public bool IsLoginValid(out string message)
        {
            message = string.Empty;
            if (Login.Length == 0)
            {
                message = "Login é requerido.";
                return false;
            }
            return true;
        }

        public bool IsEmailValid(out string message)
        {
            message = string.Empty;
            if (Email.Length == 0)
            {
                message = "Email é requerido.";
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                if (addr.Host != "prosoft.com.br")
                {
                    message = "Domínio diferente de \"prosoft.com\".";
                    return false;
                }
            }
            catch
            {
                message = "Email é inválido.";
                return false;
            }
            return true;
        }

        public bool IsSquadValid(out string message)
        {
            message = string.Empty;
            if (Squad.Length == 0)
            {
                message = "Squad é requerido.";
                return false;
            }
            return true;
        }

        #endregion      

    }
}