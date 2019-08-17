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
            DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.AddDiscount(Category.Electronics, 0);
            
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            discountConfiguration.AddProductDiscount(redmiNote5Pro);
            discountConfiguration.AddProductDiscount(redmiY3);
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2,discountConfiguration);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2,discountConfiguration);
            //DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.Discount = 0.05;
            Cart cart = new Cart(discountConfiguration);
            cart.AddItem(RedmiY3CartItem);
            cart.AddItem(RedmiNote5ProCartItem);
            
            Assert.Equal(41796.2, cart.TotalPriceOfCart());
        }
    }
    public class Price_In_CartItem
    { 
        [Fact]
        public void Test_For_Price_In_CartItem()
        {
            DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.AddDiscount(Category.Electronics, 0);
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            discountConfiguration.AddProductDiscount(redmiNote5Pro);
            discountConfiguration.AddProductDiscount(redmiY3);
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2,discountConfiguration);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2,discountConfiguration);
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
            DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.AddDiscount(Category.Electronics, 0);
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            discountConfiguration.AddProductDiscount(redmiNote5Pro);
            discountConfiguration.AddProductDiscount(redmiY3);
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2,discountConfiguration);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2,discountConfiguration);
           
            discountConfiguration.Discount = 0.01;
            Cart cart = new Cart(discountConfiguration);
            cart.AddItem(RedmiY3CartItem);
            Assert.Equal(RedmiY3CartItem, cart.GetCartItems()[0]);
        }
    }
    public class Update_Quantity_In_Cart
    {
        [Fact]

        public void Test_For_Update_Quantity_In_Cart()
        {
            DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.AddDiscount(Category.Electronics, 0);
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            discountConfiguration.AddProductDiscount(redmiNote5Pro);
            discountConfiguration.AddProductDiscount(redmiY3);
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2, discountConfiguration);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2, discountConfiguration);
            
            discountConfiguration.Discount = 0.05;
            Cart cart = new Cart(discountConfiguration);
            cart.AddItem(RedmiNote5ProCartItem);
            CartItem RedmiNote5ProDummy = new CartItem(redmiNote5Pro, 4, discountConfiguration);
            cart.AddItem(RedmiNote5ProDummy);
            Assert.Equal(6, (cart.GetCartItems())[0].Quantity);
        }
    }
    public class Category_test
    {
        [Fact]
        public void Test_For_Product_Category()
        {
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            Assert.Equal( Category.Electronics, redmiNote5Pro.Category);
        }
    }
    public class Final_Price_Of_Cart
    {
        [Fact]
        public void Test_For_Final_Price_Of_Cart()
        {
            DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.AddDiscount(Category.Electronics, 0.05);
            discountConfiguration.AddDiscount(Category.Books, 0.1);
            HalfGirlFriend halfGirlFriend = new HalfGirlFriend();
            RedmiNote5Pro redmiNote5Pro = new RedmiNote5Pro();
            RedmiY3 redmiY3 = new RedmiY3();
            discountConfiguration.AddProductDiscount(redmiNote5Pro);
            discountConfiguration.AddProductDiscount(redmiY3);
            discountConfiguration.AddProductDiscount(halfGirlFriend);
            CartItem HalfGirlFriendCartItem= new CartItem(halfGirlFriend, 5, discountConfiguration);
            CartItem RedmiY3CartItem = new CartItem(redmiY3, 2, discountConfiguration);
            CartItem RedmiNote5ProCartItem = new CartItem(redmiNote5Pro, 2, discountConfiguration);
            //DiscountConfiguration discountConfiguration = new DiscountConfiguration();
            discountConfiguration.Discount = 0.05;
            Cart cart = new Cart(discountConfiguration);
            cart.AddItem(RedmiY3CartItem);
            cart.AddItem(RedmiNote5ProCartItem);
            cart.AddItem(HalfGirlFriendCartItem);
            CartItem HalfGirlFriendCartItemdummy = new CartItem(halfGirlFriend, 5, discountConfiguration);
            cart.AddItem(HalfGirlFriendCartItemdummy);
            Assert.Equal(48256.39, cart.TotalPriceOfCart());
        }
    }
}
