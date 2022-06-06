using EntegraIntegration.ConsoleApp.Integrations.Helpers;
using EntegraIntegration.ConsoleApp.Integrations.Models.Request;
using EntegraIntegration.ConsoleApp.Integrations.Models.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EntegraIntegration.ConsoleApp.Integrations.Services
{
    public interface IEntegraIntegrationService
    {
        Task<EntegraTokenResponse> GetToken(EntegraTokenRequest request);
        Task<EntegraProductResponse> GetProducts(int pageNumber = 1);

    }

    public class EntegraIntegrationService : IEntegraIntegrationService
    {
        private readonly HttpClient _httpClient;
        public EntegraIntegrationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EntegraProductResponse> GetProducts(int pageNumber = 1)
        {
            var response =
                await _httpClient.GetAsync(RouteHelper.Product.GetProducts(pageNumber));

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsAsync<EntegraProductResponse>();
        }

        public async Task<EntegraTokenResponse> GetToken(EntegraTokenRequest request)
        {
            var response = 
                await _httpClient.PostAsJsonAsync<EntegraTokenRequest>(
                RouteHelper.User.Token,request);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsAsync<EntegraTokenResponse>();
        }
    }
}
