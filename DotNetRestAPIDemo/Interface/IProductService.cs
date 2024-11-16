using DotNetRestAPIDemo.Helper;

namespace DotNetRestAPIDemo.Interface
{
    public interface IProductService
    {
        Task<Response> GetProductsAsync();
    }
}
