using CMSy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSy.Models
{
    public class Receipt
    {
        private List<Product> products;
        private int idTable;
        private int order_id;
        public int id_Table
        {
            get { return idTable; }
            set { idTable = value; }
        }

        public int OrderId 
        {
            get { return order_id; }
            set { order_id = value; }
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
            int idTable = id_Table;
            int order_id = OrderId;
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