using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_it_Out_pg78
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)

            {
                for (int column = 0; column < row + 1; column++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
                // this is copied verbatum from the book for the example before the try it out. wht does mine not build out to the right?
            }

        }
    }
}
