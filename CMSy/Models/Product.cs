using System.Xml.Linq;

namespace CMSy.Models
{
    public class Product
    {
        private int product_id;
        private double price;
        private string productName;
        private bool is_cold;
        private bool is_vegan;

        public int ProductId
        { 
            get { return product_id; } 
            set { product_id = value; } 
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public bool IsCold
        {
            get { return is_cold; }
            set { is_cold = value; }
        }

        public bool IsVegan
        {
            get { return is_vegan; }
            set { is_vegan = value; }
        }

        public Product(int product_id, double price, string productName, bool is_cold, bool is_vegan)
        {
            ProductId= product_id;
            Price = price;
            ProductName = productName;
            IsCold = is_cold;
            IsVegan = is_vegan;
        }

        public override string ToString()
        {
            string productName = ProductName;
            string is_cold = "";
            if (IsCold)
            {
                is_cold = "hot";
            }
            else
            {
                is_cold = "cold";
            }
            string is_vegan = "";
            if (IsVegan)
            {
                is_vegan = "vegan";
            }
            else
            {
                is_vegan = "not vegan";
            }
            string prodctTypeString = $"{productName} is {is_cold} and {is_vegan}";
            return prodctTypeString;
        }

    }
}
