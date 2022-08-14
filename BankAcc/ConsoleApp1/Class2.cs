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
        public InvalidNameException(string name) : base(String.Format("Invalid Name: {0}", name)) { 
        
        }

    }
}
