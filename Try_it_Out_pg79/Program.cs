using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Try_it_Out_pg79
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (var x = 1; x <= 100; x++)
            {
                if (x%3 == 0 && x%5==0) // so i had this at the bottom fist and i could not get FIzzBuzz why does it have to be at the top? Also i had the right formla at first except for % sign had to sneak peak at yours to get that.
                {
                    Console.WriteLine("fizzbuzz");
                }
              
                else if (x%3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                
                    
                else if (x%5 == 0)
                {
                    Console.WriteLine("buzz");
                }
               
                else
                {
                    Console.WriteLine(x);

                }

            }

        }
    }
}
