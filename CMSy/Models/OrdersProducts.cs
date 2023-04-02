namespace CMSy.Models
{
    public class OrdersProducts
    {
        //orders_products -> product_id, order_id, quantity
        private int order_id;
        private int product_id;
        private int quantity;

        public int OrderId
        {
            get { return order_id; }
            set { order_id = value; }
        }

        public int ProductId
        {
            get { return product_id; }
            set { product_id = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public OrdersProducts(int order_id, int product_id, int quantity)
        {
            OrderId = order_id;
            ProductId = product_id;
            Quantity = quantity;
        }
    }
}
