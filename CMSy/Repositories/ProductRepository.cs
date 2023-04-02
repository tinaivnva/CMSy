using CMSy.DataFolder;
using CMSy.Models;
using CMSy.Repositories.Interfaces;

namespace CMSy.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private MVCProductDbContext context;

        public ProductRepository(MVCProductDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAll()
            => context.Products.ToList();

        public Product GetById(int product_id)
            => context.Products.FirstOrDefault(p => p.ProductId == product_id);

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            context.Products.Remove(GetById(id));
            context.SaveChanges();
        }
    }
}
