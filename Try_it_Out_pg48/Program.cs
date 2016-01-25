using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_it_Out_pg48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the clyinder");
            var radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the clyinder");
            var height = Int32.Parse(Console.ReadLine());
            float pi = 3.1415926f;
            var Volume = (pi*radius*radius*height);
            var surfaceArea = 2*pi*(radius + height);
            Console.WriteLine("The clyinder's volume is"+ Volume);
            Console.WriteLine("The surface area is"+ surfaceArea);
            Console.ReadLine();



        }
    }
}
