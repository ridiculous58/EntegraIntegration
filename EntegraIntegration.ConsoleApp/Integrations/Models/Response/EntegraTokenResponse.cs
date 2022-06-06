using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Integrations.Models.Response
{
    public class EntegraTokenResponse
    {
        [JsonProperty("refresh")]
        public string Refresh { get; set; }
        
        [JsonProperty("access")] 
        public string Access { get; set; }
    }


}
