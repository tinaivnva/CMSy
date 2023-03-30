using Cafe_Management_System.Models;
using CafeManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe_Management_System.Controllers
{
    public class ReceiptController : Receipt
    {
        private List<Receipt> receipts;
        private List<Product> products;

        public ReceiptController()
        {
            products = new List<Product>();
            receipts = new List<Receipt>();
        }

        public string ProcessProductCommand(List<string> args)
        {
            int product_id = int.Parse(args[0]);
            string productName = args[1];
            double price = double.Parse(args[2]);
            bool is_cold = bool.Parse(args[3]);
            bool is_vegan = bool.Parse(args[4]);

            var product = new Product(product_id, price, productName, is_cold, is_vegan);
            products.Add(product);

            return $"This table has ordered {productName}.";
        }
        
        public string CheckoutCommand(List<string> args)
        {
            int idTable = int.Parse(args[0]);

            var receipt = new Receipt(idTable);
            products.ForEach(product => receipt.AddProduct(product));
            receipts.Add(receipt);

            double sumOfProductPrices = products.Sum(product => product.Price);
            return $"The total of this table is {sumOfProductPrices}";
        }
        public ActionResult ProcessInfoCommand()
        {
            
            return View();
        }
    }
}