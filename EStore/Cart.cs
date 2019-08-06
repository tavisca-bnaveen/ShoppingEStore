using System.Collections.Generic;

namespace EStore
{
    public class Cart
    {
        List<CartItem> cartItems = new List<CartItem>();
        double discount;
        public Cart(DiscountConfiguration discountConfiguration)
        {
            discount = discountConfiguration.Discount;

        }
        public void AddItem(CartItem cartItem)
        {
            //CartItem cartItem = new CartItem(product, quantity);

            if (!IsCartItemPresent(cartItem))
                cartItems.Add(cartItem);
            else
            {
                CartItem _cartItem = cartItems.Find(item => item.product == cartItem.product);
                _cartItem.Quantity += cartItem.Quantity;
                _cartItem.TotalPrice += cartItem.TotalPrice;
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
       

        public void RemoveItem(CartItem cartItem)
        {
            int index=cartItems.IndexOf(cartItem);
            cartItems[index].Quantity -= cartItem.Quantity;
            cartItems[index].TotalPrice -= cartItem.TotalPrice;
            
            if (cartItems[index].Quantity == 0)
                cartItems.RemoveAt(index);
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
