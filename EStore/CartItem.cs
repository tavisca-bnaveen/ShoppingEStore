namespace EStore
{
    public class CartItem
    {
        public Product product;
        public int Quantity;
        private double _TotalPrice;
        public CartItem(Product product,int Quantity)
        {
            this.product = product;
            this.Quantity = Quantity;
            _TotalPrice = product.Price * Quantity;
        }   
        public double GetTotalPrice()
        {
            return _TotalPrice;
        }
    }
    
}
