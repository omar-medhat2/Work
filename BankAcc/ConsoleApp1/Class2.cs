using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException() : base() { 
        
        }
        public InvalidNameException(string name) : base(String.Format("Invalid Name: {0}, Please only use letters", name)) { 
        
        }

    }

    internal class InvalidIDException : Exception
    {
        public InvalidIDException() : base(String.Format("Invalid ID, please use a 14 digit ID")) { 
        
        }
        
    }

    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base(String.Format("Invalid Age please only use numbers"))
        {

        }
    }

    internal class InvalidDepositException : Exception
    {
        public InvalidDepositException() : base(String.Format("Invalid deposit please only use positive numbers"))
        {

        }
    }
}
