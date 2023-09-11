using ProductsApi.Domain.Model;

namespace ProductsApi.Infra.Repositories
{
    public interface ProductRepositoryInterface
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
