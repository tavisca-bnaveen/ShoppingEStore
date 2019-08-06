namespace EStore
{
    public class CartItem
    {
        public Product product;
        public int Quantity;
        public double TotalPrice;
        public CartItem(Product product,int Quantity,DiscountConfiguration discountConfiguration)
        {
            this.product = product;
            this.Quantity = Quantity;
            TotalPrice = product.Price*(1-discountConfiguration.CategoryDiscount[product.Category]) * Quantity;
        }   
        public double GetTotalPrice()
        {
            return TotalPrice;
        }
    }
    
}
