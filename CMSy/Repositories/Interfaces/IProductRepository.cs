using CMSy.DataFolder;
using CMSy.Models;

namespace CMSy.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int product_id);

        public void AddProduct(Product product);

        public void EditProduct(Product product);

        public void DeleteProduct(int product_id);
    }
}
