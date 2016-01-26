using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Try_it_Out_pg68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number that you would like to be computed?");
            var firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter a second number that you would to be computed?");
            var secondNumber = Int32.Parse(Console.ReadLine());

            if (firstNumber > 0 && secondNumber > 0)
                Console.WriteLine("The number is positive");

           else if (firstNumber <0 && secondNumber <0)
                Console.WriteLine("The number is positive");
           else
        
               Console.WriteLine("The number is negative");
        
          
           







        }
    }
}
