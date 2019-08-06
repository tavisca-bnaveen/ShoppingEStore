using System.Collections.Generic;

namespace EStore
{
    public class DiscountConfiguration
    {
        public double Discount { get; set; }
        public Dictionary<Category, double> CategoryDiscount = new Dictionary<Category, double>();

        public void AddDiscount(Category category,double discount)
        {
            CategoryDiscount[category] = discount;
        }
    }
}
