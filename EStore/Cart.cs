using System.Collections.Generic;

namespace EStore
{
    public class Cart:IDiscount
    {
        List<CartItem> cartItems = new List<CartItem>();
        double discount=0;
        public void AddItem(CartItem cartItem)
        {
            //CartItem cartItem = new CartItem(product, quantity);

            if (!IsCartItemPresent(cartItem))
                cartItems.Add(cartItem);
            else
            {
                CartItem _cartItem = cartItems.Find(item => item.product == cartItem.product);
                _cartItem.Quantity += cartItem.Quantity;
            }

        }
        public bool IsCartItemPresent(CartItem cartItem)
        {
            CartItem _cartItem = cartItems.Find(item => item.product == cartItem.product);
            if (_cartItem == null)
                return false;
            else
                return true;
        }
        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }
        public double GetDiscount()
        {
            return discount;
        }

        public void RemoveItem(CartItem cartItem)
        {
            int index=cartItems.IndexOf(cartItem);
            cartItems.RemoveAt(index);
        }

        public void SetDiscount(double discount)
        {
            this.discount = discount;
        }
        public double TotalPriceOfCart()
        {
            double totalPrice = 0;
            for(int i=0;i<cartItems.Count;i++)
            {
                totalPrice += (cartItems[i].GetTotalPrice());
            }
            double discountInPrice = totalPrice * discount;
            return totalPrice - discountInPrice;
        }
    }
    
}
