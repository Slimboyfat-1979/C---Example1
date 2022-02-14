using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_03
{
    public class Controller
    {
        public List<Customer> customerList = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }
    }
}
