using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Name

    {
        internal string fname;
        internal string   mid;
        internal string lname;
        internal string title;

        
        public Name(string fname, string mid, string lname, string title)
        {
            this.fname = fname;
            this.mid = mid;
            this.lname = lname;
            this.title = title;
        }
        public override string ToString()
        {
            string output = "";
            if (!string.IsNullOrEmpty(title))
            {
                output += title;
            }

            output += (" " + fname + " " + mid + "." + " " + lname);

            return output;
        }

    }
}
