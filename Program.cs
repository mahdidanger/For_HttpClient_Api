// See https://aka.ms/new-console-template for more information
using ForAPI;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new ProductClient();

        
        await client.GetProductsAsync();

        
        var NewProduct = new Product { Name = "Phone", Price = 100.00 };
        await client.AddProductAsync(NewProduct);
    }
}

