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

        public string Speak()
        {
            return "Hi I'm Software Developer";
        }
    }
}
