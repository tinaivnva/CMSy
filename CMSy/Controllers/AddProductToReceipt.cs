using CMSy.DataFolder;
using CMSy.Models;
using CMSy.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CMSy.Controllers
{
    public class AddProductToReceipt : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public AddProductToReceipt(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddOrderViewModel addOrderRequest)
        {
            var order = new Receipts()
            {
                Id = Guid.NewGuid(),
                TableNumber = addOrderRequest.TableNumber,
                ProductName = addOrderRequest.ProductName,
                Quantity = addOrderRequest.Quantity
            };
            await mvcDemoDbContext.Receipt.AddRangeAsync(order);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
