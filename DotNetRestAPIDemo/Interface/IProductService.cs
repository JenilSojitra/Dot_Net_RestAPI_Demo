using DotNetRestAPIDemo.Helper;
using DotNetRestAPIDemo.Models;

namespace DotNetRestAPIDemo.Interface
{
    public interface IProductService
    {
        Task<Response> GetProductsAsync();
        Task<Response> GetProductByIdAsync(int Id);
        Task<Response> AddProductAsync(Product product);
        Task<Response> UpdateProductAsync(Product product);
        Task<Response> RemoveProductAsync(int Id);
    }
}
