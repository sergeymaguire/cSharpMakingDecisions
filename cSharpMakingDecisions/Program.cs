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

            const int HIGH = 10, LOW = 5;
            string numberString;
            int number;
            Console.Write("Enter a number: ");
            numberString = Console.ReadLine();
            number = Convert.ToInt32(numberString);
            integerDecison(HIGH, LOW, number);
        }

        private static void integerDecison(int HIGH, int LOW, int number)
        {
            if (number < HIGH)
            {
                Console.WriteLine("{0} is between {1} and {2}.", number, LOW, HIGH);
                Console.ReadLine();
            }
            else if (number >= HIGH)
            {
                Console.WriteLine("{0} is not between {1} and {2}.", number, LOW, HIGH);
                Console.ReadLine();
            }
        }
    }
}
