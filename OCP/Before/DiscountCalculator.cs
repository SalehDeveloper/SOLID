using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Before
{
    public class DiscountCalculator
    {
        public decimal  Calculate (decimal amount , string discountType)
        {
            if (discountType == "None")
                    return amount;

             else if (discountType == "Percentage")
                    return amount * 0.9m;

            // Add more logic here when new types are added (violates OCP)
            return amount;
        }
    }
}
