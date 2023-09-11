using ProductsApi.Domain.Model;

namespace ProductsApi.App.Interfaces
{
    public interface ProductServiceInterface
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
