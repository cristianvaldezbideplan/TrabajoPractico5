using AppFakeStore.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using AppFakeStore.Utils;
using System.Net.Http.Json;

namespace AppFakeStore.Services;

public class ProductoService : IProductoService
{
    HttpClient Producto;

    private static JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public ProductoService()
    {
        Producto = new HttpClient();

        Producto.BaseAddress = new Uri(Constants.ApiDataServer);
        Producto.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    public async Task<IEnumerable<Producto>> GetProductsAsync()
    {
        var response = await Producto.GetAsync(Constants.ProductsEndpoint);

        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<IEnumerable<Producto>>(options);

        return default;
    }
}
