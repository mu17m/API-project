using FirstWebApp.Models;

namespace FirstWebApp.Services.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public Product? GetProductById(int id);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProductById(int id);

    }
}
