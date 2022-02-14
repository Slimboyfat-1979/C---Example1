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
        Controller control = Form1.GetController();
        public Home()
        {
            InitializeComponent();
            
            listBox1.Items.Add("Name\t\tEveryday\t\tInvestment\tOmni");

            foreach (Customer c in control.customerList)
            {
                listBox1.Items.Add(c.Name + "\t\t$" + c.E.Balance + "\t\t$" + c.I.Balance + "\t\t$" + c.O.Balance);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCustomer().Show();
        }
    }
}
