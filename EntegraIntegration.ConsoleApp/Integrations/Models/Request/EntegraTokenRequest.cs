using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Integrations.Models.Request
{
    public class EntegraTokenRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
