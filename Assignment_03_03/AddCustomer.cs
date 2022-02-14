using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_03_03
{
    public partial class AddCustomer : Form1
    {
        Controller control = Home.GetController();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = custTxt.Text;
            double eBalance = Convert.ToDouble(eBalanceTxt.Text);
            double iBalance = Convert.ToDouble(iBalanceTxt.Text);
            double oBalance = Convert.ToDouble(oBalanceTxt.Text);

            Everyday everyday = new Everyday(eBalance);
            Investment investment = new Investment(iBalance);
            Omni omni = new Omni(iBalance);

            control.AddCustomer(new Customer(name, everyday, investment, omni));

            MessageBox.Show("New customer has been added!");

            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
