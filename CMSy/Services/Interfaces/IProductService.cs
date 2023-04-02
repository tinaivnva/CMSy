using CMSy.Models;

namespace CMSy.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int product_id);
        public void AddProduct(Product product);
        public void EditProduct(Product product);
        public void DeleteProduct(int product_id);
    }
}
