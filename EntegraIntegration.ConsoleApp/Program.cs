using EntegraIntegration.ConsoleApp.Integrations.Helpers;
using EntegraIntegration.ConsoleApp.Integrations.Models.Response;
using EntegraIntegration.ConsoleApp.Integrations.Services;
using EntegraIntegration.ConsoleApp.Models;
using EntegraIntegration.ConsoleApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net.Http;

namespace EntegraIntegration.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var context = new EntegraDbContext();

            context.Products.RemoveRange(context.Products);
        
            IEntegraIntegrationService integrationService = new EntegraIntegrationService(client);

            var tokenModel = integrationService.GetToken(new EntegraTokenRequestBuilder().Build()).GetAwaiter().GetResult();
            Console.WriteLine($"Token: {tokenModel.Access}");
            Authenticate(client, tokenModel.Access);

            var products =  integrationService.GetProducts().GetAwaiter().GetResult();
            if (products != null)
            {
                AddProducts(context, products);
                UpdateProduct(context);
                DeleteProduct(context);
            }

        }

        private static void UpdateProduct(EntegraDbContext context)
        {
            var updatedProduct = context.Products.FirstOrDefault();
            updatedProduct.Name = $"{updatedProduct.Name} => Düzenlendi";
            context.Products.Update(updatedProduct);
            context.SaveChanges();
        }
        private static void DeleteProduct(EntegraDbContext context)
        {
            var deletedProduct = context.Products.ToList().LastOrDefault();
            context.Products.Remove(deletedProduct);
            context.SaveChanges();
        }

        private static void AddProducts(EntegraDbContext context, EntegraProductResponse products)
        {
            var addedProducts = products.porductList.Take(5).Select(x =>
            {
                long.TryParse(x.quantity, out var quantity);
                return new Product
                {
                    Id = Guid.NewGuid(),
                    Name = x.name,
                    ProductCode = x.productCode,
                    Quantity = quantity
                };
            }).ToList();

            context.Products.AddRange(addedProducts);
            context.SaveChanges();
        }

        static void Authenticate(HttpClient client,string token)
        {
            var name = "Authorization";
            if (client.DefaultRequestHeaders.Contains(name))
            {
                client.DefaultRequestHeaders.Remove(name);
            }
            client.DefaultRequestHeaders.Add(name, $"JWT {token}");

            var userAgent = "User-Agent";
            if (client.DefaultRequestHeaders.Contains(userAgent))
            {
                client.DefaultRequestHeaders.Remove(userAgent);
            }
            client.DefaultRequestHeaders.Add(userAgent, "PostmanRuntime/7.29.0");
        }
    }

}
