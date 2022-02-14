using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_03
{
    public class Omni : Account
    {
        public override double Balance { get; set; }

        public Omni(double balance)
        {
            this.Balance = balance;
        }
    }
}
