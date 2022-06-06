using EntegraIntegration.ConsoleApp.Integrations.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Integrations.Helpers
{
    public class EntegraTokenRequestBuilder
    {
        private readonly EntegraTokenRequest _entegraTokenRequest;

        public EntegraTokenRequestBuilder()
        {
            _entegraTokenRequest = new EntegraTokenRequest
            {
                Email = "apitestv2@entegrabilisim.com",
                Password = "apitestv2"
            };
        }

        public EntegraTokenRequest Build()
        {
            return _entegraTokenRequest;
        }
    }


}
