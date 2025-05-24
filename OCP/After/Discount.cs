using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.After
{
    // know you can add any type of discount without modifying existing code 
    public abstract class Discount
    {
        public abstract decimal Calculate(decimal amount);
    }
}
