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
            Classes_Objects classes = new Classes_Objects();
            classes.Name = "Peter";
            lblName.Text = classes.Name;
            classes.Surname = "Geswint";
            lblSurname.Text = classes.Surname;
            lblSpeak.Text = classes.Speak();
        }
    }
}
