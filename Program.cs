// See https://aka.ms/new-console-template for more information
using ForAPI;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new ProductClient();

        // دریافت محصولات
        await client.GetProductsAsync();

        // افزودن محصول جدید
        var newProduct = new Product { Name = "Product1", Price = 99.99M };
        await client.AddProductAsync(newProduct);
    }
}

