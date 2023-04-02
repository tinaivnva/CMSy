using CMSy.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMSy.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public void AddOrder(Order order);
        public void AddProductToOrder(Product product);
        public void RemoveProductFromOrder(Product product);
        
    }
}
