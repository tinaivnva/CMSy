using CMSy.Models;
using CMSy.DataFolder;
using CMSy.Services.Interfaces;
using CMSy.Repositories.Interfaces;

namespace CMSy.Services
{
    public class ProductService : IProductRepository
    {
        private IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
            public IEnumerable<Product> GetAll()
            => productRepository.GetAll();

        public Product GetById(int iproduct_id)
            => productRepository.GetById(iproduct_id);

        public void AddProduct(Product product)
        {
            productRepository.AddProduct(product);
        }


        public void EditProduct(Product product)
        {
            productRepository.EditProduct(product);
        }

        public void DeleteProduct(int product_id)
        {
            productRepository.DeleteProduct(product_id);
        }
    }
}
