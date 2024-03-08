using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects___Example
{
    internal interface IDeveloper
    {
        string Program();
        string Coffee();
        string Sleep();
    }

    abstract class WebDev : IDeveloper
    { 
        public abstract string Program();
        public abstract string Coffee();
        public string Sleep()
        {
            return "Can't sleep if all bugs aren't fixed.";
        }
    }

    class Junior : WebDev
    {
        public override string Program()
        {
            return "I code by doing what I'm told.";
        }
        public override string Coffee()
        {
            return "Coffee is life.";
        }
    }


}
