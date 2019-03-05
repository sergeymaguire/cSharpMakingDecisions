using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {

            integerdecison();
            string numbersString;
            int counter = 1;
            int num1, num2, num3;
            Console.Write("Enter a integer: #{0} ", counter++);
            numbersString = Console.ReadLine();
            num1 = Convert.ToInt32(numbersString);
            Console.Write("Enter a integer: #{0} ", counter++);
            numbersString = Console.ReadLine();
            num2 = Convert.ToInt32(numbersString);
            Console.Write("Enter  integer: #{0} ",counter++);
            numbersString = Console.ReadLine();
            num3 = Convert.ToInt32(numbersString);
            if (num1 == num2)
            {
                Console.WriteLine("the first number {0} and the second number {1} are equal", num1, num2);
                Console.ReadLine();
            }
            else if (num2 == num3)
            {
                Console.WriteLine("the second number {0} and last number {1} are equal", num2, num3);
                Console.ReadLine();
            } else if(num1 == num3) {
                Console.WriteLine("The first number {0} and last number {1} are equal", num1, num3);
                Console.ReadLine();
            }else
            {
                Console.WriteLine("No two numbers are equal");
                Console.ReadLine();
            }
               
            
        }

        private static void integerdecison()
        {
            const int high = 10, low = 5;
            int number;
            Console.Write("enter a number: ");
            string numberstring = Console.ReadLine();
            number = Convert.ToInt32(numberstring);
           

            if (number < high)

            {
                Console.WriteLine("{0} is between {1} and {2}.", number, low, high);
                Console.ReadLine();
            }
            else if (number >= high)
            {
                Console.WriteLine("{0} is not between {1} and {2}.", number, low, high);
                Console.ReadLine();
            }
        }

    }
}
