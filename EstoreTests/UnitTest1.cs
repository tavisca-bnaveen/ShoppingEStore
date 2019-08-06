using System;
using Xunit;
using EStore;
namespace EstoreTests
{
    public class Total_price_Of_Cart
    {
        [Fact]
        public void Test_For_Total_price_Of_Cart()
        {
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2);
            Cart cart = new Cart();
            cart.AddItem(RedmiY3CartItem);
            cart.AddItem(RedmiNote5ProCartItem);
            cart.SetDiscount(0.05);
            Assert.Equal(41796.2, cart.TotalPriceOfCart());
        }
    }
    public class Price_In_CartItem
    { 
        [Fact]
        public void Test_For_Price_In_CartItem()
        {
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2);
            Assert.Equal(19998, RedmiY3CartItem.GetTotalPrice());
        }

    }
    public class Product_Test
    {
        [Fact]
        public void Test_For_Product_price()
        {
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            Assert.Equal(11999, redmiNote5Pro.Price);
        }
    }
    public class CartItem_AddItem
    {
        [Fact]
        public void Test_for_AddItem_In_cart()
        {
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2);
            Cart cart = new Cart();
            cart.AddItem(RedmiY3CartItem);
            Assert.Equal(RedmiY3CartItem, cart.GetCartItems()[0]);
        }
    }
    public class Update_Quantity_In_Cart
    {
        [Fact]

        public void Test_For_Update_Quantity_In_Cart()
        {
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2);
            Cart cart = new Cart();
            cart.AddItem(RedmiNote5ProCartItem);
            CartItem RedmiNote5ProDummy = new CartItem(redmiNote5Pro, 4);
            cart.AddItem(RedmiNote5ProDummy);
            Assert.Equal(6, (cart.GetCartItems())[0].Quantity);
        }
    }
}
