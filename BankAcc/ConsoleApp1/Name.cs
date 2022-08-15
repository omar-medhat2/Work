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
        //internal string title;
        internal Title title;

        
        public Name(string fname, string mid, string lname, short titleinput)
        {
            this.fname = fname;
            this.mid = mid;
            this.lname = lname;
            this.title = GetTitle(titleinput);
        }

        public static Title GetTitle(short titleinput)
        {
            switch (titleinput)
            {
                case 1: return Title.Eng;
                case 2: return Title.Dr;
                case 3: return Title.Mr;
                case 4: return Title.Ms;
                case 5: return Title.Mrs;
                default: return Title.Unknown;
            }
        }
        public override string ToString()
        {
            
            string output = "";

           if (title != Title.Unknown)
            {
                output += title + "." + " ";
            }

            output += (fname + " " + mid + "." + " " + lname);

            return output;
        }

    }
}
