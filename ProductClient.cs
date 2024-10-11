using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ForAPI
{
    public class ProductClient
    {
        private readonly HttpClient _client;

        public ProductClient()
        {
            _client = new HttpClient();
        }

        public async Task GetProductsAsync()
        {
            var response = await _client.GetAsync("https://localhost:7160/api/products");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonData);
            }
        }

        public async Task AddProductAsync(Product product)
        {
            
            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("https://localhost:7160/api/products", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Product added successfully.");
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
