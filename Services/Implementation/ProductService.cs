using FirstWebApp.Models;
using FirstWebApp.Services.Interfaces;

namespace FirstWebApp.Services.Implementation
{
    public class ProductService : IProductService
    {
        #region Fields
        List<Product> Products;
        #endregion

        #region Constructor
        public ProductService()
        {
            Products = new List<Product>
            {
                new Product(){Id=1, Name="Product1", Price=12},
                new Product(){Id=2, Name="Product2", Price = 15}
            };
        }
        #endregion

        #region Implement
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void DeleteProductById(int id)
        {
            var pro = GetProductById(id);
            if(pro != null)
            {
                Products.Remove(pro);
            }
        }
        public Product? GetProductById(int id)
        {
            return Products.Find(el => el.Id == id);
        }
        public List<Product> GetProducts()
        {
            return Products;
        }
        public void UpdateProduct(Product product)
        {
            var pro = GetProductById(product.Id);
            if(pro != null)
            {
                pro.Name = product.Name;
                pro.Price = product.Price;
            }
        }

        #endregion
    }
}
