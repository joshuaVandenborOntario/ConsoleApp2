using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            if(1 == 2)
            {
                Console.WriteLine("This is impossible");
            }
        }

        public String returnString()
        {
            return "Hello World";
        }
    }
}
