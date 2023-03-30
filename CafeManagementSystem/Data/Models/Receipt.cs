using CafeManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafe_Management_System.Models
{
    public class Receipt
    {
        private List<Product> products;
        private int idTable;
        public int id_Table
        {
            get { return idTable; }
            private set { idTable = value; }
        }
        public Receipt(int idTable)
        {
            id_Table = idTable;
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public override string ToString()
        {
            double sumOfProductPricces = products.Sum(product => product.Price);
            string receipt = $"Reciept of Table№{id_Table}"
 + Environment.NewLine
 + $"Total Price: {sumOfProductPricces}"
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