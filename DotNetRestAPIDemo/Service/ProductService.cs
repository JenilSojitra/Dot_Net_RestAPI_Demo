using DotNetRestAPIDemo.Helper;
using DotNetRestAPIDemo.Interface;
using DotNetRestAPIDemo.Models;

namespace DotNetRestAPIDemo.Service
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>();

        public async Task<Response> GetProductsAsync()
        {
            try
            {
                // Simulate an asynchronous operation
                await Task.Delay(100); // Simulates delay, replace with actual async call if needed

                if (_products.Count == 0)
                {
                    _products = await SeedModelDatas.GetProductListAsync(); // Assuming SeedModelDatas is also async
                }

                return new Response
                {
                    status = "success",
                    Message = "Products retrieved successfully...",
                    data = _products
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    status = "error",
                    Message = $"{ex.Message} \n {ex.InnerException?.Message}",
                };
            }
        }
    }
}
