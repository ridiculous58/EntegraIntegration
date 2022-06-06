using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Integrations.Models.Response
{
    public class EntegraErrorResponse
    {
        [JsonProperty("detail")]
        public string Detail { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("messages")]
        public IList<MessageResponse> Messages { get; set; }
    }

    public class MessageResponse
    {
        [JsonProperty("token_class")]
        public string TokenClass { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

}
