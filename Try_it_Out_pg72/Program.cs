using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Try_it_Out_pg72
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please begin your math Problem by entering a number?");
            var numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the type of Mathmatical equation you would like to use? +, -, *, /, %");
            var operation = Console.ReadLine();
            Console.WriteLine("Please enter your second numer to have your equation computed.");
            var secondNumber = Int32.Parse(Console.ReadLine());

            var answer = Resultant(numberOne, secondNumber, operation);
            Console.WriteLine("answer of " + numberOne + " " + operation + " " + secondNumber + " "+ answer);
        }

        public static int Resultant(int numberOne, int secondNumber, string operation)
        {
            int answer = 0;

            switch (operation)
            {
                case "+":
                    answer = numberOne + secondNumber;
                    break;
                case "-":
                    answer = numberOne - secondNumber;
                    break;
                case "*":
                    answer = numberOne * secondNumber;
                    break;
                case "/":
                    answer = numberOne / secondNumber;
                    break;
                case "%":
                    answer = numberOne % secondNumber;
                    break;


            }
            return answer;
        }
           // i am as lost as last years easter egg what am i missing? this is the first one that i had to go look at your github to add some stuff i
           // did not know that i needed please help!


        }
    }
    
