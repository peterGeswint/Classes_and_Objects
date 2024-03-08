using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects___Example
{
    internal class Classes_Objects
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public double Fees { get; set; }

        public double GetTax(double fees)
        {
            const double TAX_AMOUNT = 0.14;
            this.Fees = fees;
            double tax = 0;
            return tax = fees * TAX_AMOUNT;
        }

        public Classes_Objects()
        {

        }

        public Classes_Objects( string name, string surname, double fees)
        {
            this.Name = name;
            this.Surname = surname;
            this.Name = name;
            this.Surname = surname;
            this.Fees = fees;
        }

        public string Speak()
        {
            return "Hi I'm Software Developer";
        }
    }
}
