using CMSy.Models;
using CMSy.Services.Interfaces;
using CMSy.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMSy.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            orderService.AddOrder(order);

            return RedirectToAction(nameof(AddProductToOrder));
        }


        [HttpPost]
        public IActionResult AddProductToOrder(Product product)
        {
            orderService.AddProductToOrder(product);

            return View(product);
        }

        [HttpPost]
        public IActionResult RemoveProductFromOrder(Product product)
        {
            orderService.RemoveProductFromOrder(product);

            return RedirectToAction(nameof(AddProductToOrder));
        }

        
    }
}
