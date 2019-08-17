using System.Collections.Generic;

namespace EStore
{
    public class DiscountConfiguration
    {
        public double Discount { get; set; }
        public Dictionary<Category, double> CategoryDiscount = new Dictionary<Category, double>();
        public Dictionary<Product, double> ProductDiscount = new Dictionary<Product, double>();

        public void AddDiscount(Category category,double discount)
        {
            CategoryDiscount[category] = discount;
        }
        public void AddProductDiscount(Product product,double discount=0)
        {
            ProductDiscount[product] = discount;
        }

    }
}
