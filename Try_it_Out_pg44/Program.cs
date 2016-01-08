using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_it_Out_pg44
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a/b;
            var remainder = a%b;
            var checkWork = b*quotient + remainder;
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            Console.WriteLine(checkWork);
        }
    }
}
