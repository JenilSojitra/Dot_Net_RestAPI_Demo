using DotNetRestAPIDemo.Models;

namespace DotNetRestAPIDemo.Helper
{
    public static class FormValidations
    {
        public static Response ProductFormValidation(Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                return new Response
                {
                    status = "error",
                    Message = "Please enter valid Product Name...",
                };
            }
            if (string.IsNullOrEmpty(product.Category))
            {
                return new Response
                {
                    status = "error",
                    Message = "Please enter valid Product Category...",
                };
            }
            if (string.IsNullOrEmpty(product.Supplier))
            {
                return new Response
                {
                    status = "error",
                    Message = "Please enter valid Product Supplier...",
                };
            }
            if (product.PurchasePrice <= 0)
            {
                return new Response
                {
                    status = "error",
                    Message = "Please enter valid Product Purchase Price...",
                };
            }
            if (product.SalesPrice <= 0)
            {
                return new Response
                {
                    status = "error",
                    Message = "Please enter valid Product Sales Price...",
                };
            }
            else
            {
                return new Response
                {
                    status = "success",
                    Message = "Form Data Is Valid...",
                };
            }
        }
    }
}
