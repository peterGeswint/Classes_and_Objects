using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_and_Objects___Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Junior webDev = new Junior();
            Classes_Objects classes = new Classes_Objects("Peter", "Geswint", 10000);
            lblName.Text = classes.Name;
            lblSurname.Text = classes.Surname;
            lblFees.Text = classes.Fees.ToString("C");
            lblSpeak.Text = classes.Speak();
            lblTax.Text = classes.GetTax(classes.Fees).ToString("C");
            lblProgram.Text = webDev.Program();
            lblCoffee.Text = webDev.Coffee();
            lblSleep.Text = webDev.Sleep();
        }
    }
}
