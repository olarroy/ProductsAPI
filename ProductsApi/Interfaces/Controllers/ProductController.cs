using Microsoft.AspNetCore.Mvc;
using ProductsApi.App.Interfaces;
using ProductsApi.Domain.Model;

namespace ProductsApi.Interfaces.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly ProductServiceInterface _productService;

        public ProductController(ProductServiceInterface productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productService.AddProduct(product);
        }

        [HttpPut]
        public void Put([FromBody] Product product)
        {
            _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
