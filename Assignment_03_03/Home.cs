using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_03_03
{
    public partial class Home : Form1
    {
        static Controller control = new Controller();
        private static Home home;
    
        int[] accountTypes = new int[3];
        Everyday e;
        Investment i;
        Omni o;
        private Home()
        {
            InitializeComponent();
            
            LoadInitialCustomers();
            LoadCustomers();
            
        }

        public static Home GetHome()
        {
            if(home == null)
            {
                home = new Home();
            }
            return home;
        }

        public static Controller GetController()
        {
            return control;
        }

        public void LoadCustomers()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Name\t\tEveryday\t\tInvestment\tOmni");

            foreach (Customer c in control.customerList)
            {
                listBox1.Items.Add(c.Name + "\t\t$" + c.E.Balance + "\t\t$" + c.I.Balance + "\t\t$" + c.O.Balance);
            }
        }

        public void LoadInitialCustomers()
        {
            string[] customerInfo;

            StreamReader reader = new StreamReader("/Data2.txt");

            while (!reader.EndOfStream)
            {
                customerInfo = reader.ReadLine().Split(',');
                accountTypes[0] = Convert.ToInt32(customerInfo[1]);
                accountTypes[1] = Convert.ToInt32(customerInfo[3]);
                accountTypes[2] = Convert.ToInt32(customerInfo[5]);

                SetUpAccounts(accountTypes, customerInfo);
            }
        }

        /* For each digit held in the accountTypes array assign a new account of that type
     using the format of the text file in the customer info array [2] [4] [6] for the ammounts
    of each account*/
        public void SetUpAccounts(int[] accountTypes, string[] customerInfo)
        {
            if (accountTypes[0] == 0)
            {
                e = new Everyday(Convert.ToDouble(customerInfo[2]));
            }

            if (accountTypes[1] == 1)
            {
                i = new Investment(Convert.ToDouble(customerInfo[4]));
            }

            if (accountTypes[2] == 2)
            {
                o = new Omni(Convert.ToDouble(customerInfo[6]));
            }
            //Passes information of the customer name, and creates 3 objects one for Everday, Investment and Omni accounts

            control.AddCustomer(new Customer(customerInfo[0], e, i, o));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCustomer().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedCustomer = listBox1.SelectedIndex;
            this.Hide();
            new ManageCustomers(selectedCustomer).Show();
        }
    }
}
