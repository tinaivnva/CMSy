﻿using CMSy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace CMSy.Models
{
    public class ReceiptController 
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

            return $"{productName}, {price}";
        }

        public string CheckoutCommand(List<string> args)
        {
            int idTable = int.Parse(args[0]);

            var receipt = new Receipt(idTable);
            products.ForEach(product => receipt.AddProduct(product));
            receipts.Add(receipt);

            double sumOfProductPrices = products.Sum(product => product.Price);
            return $"{sumOfProductPrices}";
        }

        public string ProcessEndCOmmand(List<string> args) 
        {
            int idTable = int.Parse(args[0]);
            int order_id = int.Parse(args[1]);
            double sumOfProductPrices = products.Sum(product => product.Price);
            string receipt = $"Reciept of Table№{idTable}"
            + Environment.NewLine
            + $"Order №{order_id}"
            + Environment.NewLine
            + $"Total Price: {sumOfProductPrices}"
            + Environment.NewLine
            + $"Products:";
            foreach (var product in products)
            {
                receipt += Environment.NewLine + product.ToString();
            }
            return receipt;
        }
    }
}