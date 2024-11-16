using DotNetRestAPIDemo.Helper;
using DotNetRestAPIDemo.Interface;
using DotNetRestAPIDemo.Models;

namespace DotNetRestAPIDemo.Service
{
    public class ProductService : IProductService
    {
        private static List<Product> _products = new List<Product>();

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

        public async Task<Response> GetProductByIdAsync(int Id)
        {
            try
            {
                if (Id <= 0)
                {
                    return new Response
                    {
                        status = "error",
                        Message = "Please enter valid Id...",
                    };
                }

                var product = new Product();

                // Simulate an asynchronous operation
                await Task.Delay(100); // Simulates delay, replace with actual async call if needed

                if (_products.Count == 0)
                {
                    _products = await SeedModelDatas.GetProductListAsync(); // Assuming SeedModelDatas is also async
                }

                if (_products.Any(x => x.Id == Id))
                {
                    product = _products.FirstOrDefault(x => x.Id == Id);
                }
                else
                {
                    return new Response
                    {
                        status = "error",
                        Message = "Product not available...",
                    };
                }

                return new Response
                {
                    status = "success",
                    Message = "Products retrieved successfully...",
                    data = product
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

        public async Task<Response> AddProductAsync(Product product)
        {
            try
            {
                // Simulate an asynchronous operation
                await Task.Delay(100); // Simulates delay, replace with actual async call if needed

                var formValidation = FormValidations.ProductFormValidation(product);
                if (formValidation.status.Trim().ToLower() == "error")
                {
                    return formValidation;
                }

                product.Id = _products.Count + 1;
                _products.Add(product);

                return new Response
                {
                    status = "success",
                    Message = "Products added successfully...",
                    data = product
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

        public async Task<Response> UpdateProductAsync(Product product)
        {
            try
            {
                // Simulate an asynchronous operation
                await Task.Delay(100); // Simulates delay, replace with actual async call if needed

                if (product.Id <= 0)
                {
                    return new Response
                    {
                        status = "error",
                        Message = "Please enter valid Id...",
                    };
                }

                var formValidation = FormValidations.ProductFormValidation(product);
                if (formValidation.status.Trim().ToLower() == "error")
                {
                    return formValidation;
                }

                var oldProduct = _products.FirstOrDefault(x => x.Id == product.Id);
                if (oldProduct != null)
                {
                    _products.Remove(oldProduct);
                    _products.Add(product);
                }
                else
                {
                    return new Response
                    {
                        status = "error",
                        Message = "Product not available...",
                    };
                }

                return new Response
                {
                    status = "success",
                    Message = "Products updated successfully...",
                    data = oldProduct
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

        public async Task<Response> RemoveProductAsync(int Id)
        {
            try
            {
                // Simulate an asynchronous operation
                await Task.Delay(100); // Simulates delay, replace with actual async call if needed

                if (Id <= 0)
                {
                    return new Response
                    {
                        status = "error",
                        Message = "Please enter valid Id...",
                    };
                }

                var oldProduct = _products.FirstOrDefault(x => x.Id == Id);
                if (oldProduct != null)
                {
                    _products.Remove(oldProduct);
                }
                else
                {
                    return new Response
                    {
                        status = "error",
                        Message = "Product not available...",
                    };
                }

                return new Response
                {
                    status = "success",
                    Message = "Products removed successfully...",
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
