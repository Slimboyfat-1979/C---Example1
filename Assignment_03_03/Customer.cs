using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_03
{
    public class Customer
    {
        public string Name { get; set; }
        public Everyday E { get; set; }
        public Investment I { get; set; }
        public Omni O { get; set; }

        public Customer(string name, Everyday e, Investment i, Omni o)
        {
            this.Name = name;
            this.E = e;
            this.I = i;
            this.O = o;
        }
    }
}
