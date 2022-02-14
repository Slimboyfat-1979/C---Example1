using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_03
{
    public class Controller
    {
        //This has all the customer info: Names and accounts and their balances
        public List<Customer> customerList = new List<Customer>();

        //Add a new customer here
        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public Customer GetCustomer(int index)
        {
            return customerList[index];
        }
    }
}
