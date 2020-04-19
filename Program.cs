using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int num = 0, mod = 0, x = 0;
            int a = 0, b = 0, c = 0, d = 0;
            int sum = 0;

            //Asking the user for the number
            Console.Write(" Enter a 4 digit number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Validating number
            if (1000 <= num && num <= 9999)
            {
                //Separating the digits ​​from the number
                a = num / 1000;
                mod = num % 1000;
                x = mod;
                b = x / 100;
                mod = x % 100;
                c = mod / 10;
                d = mod % 10;

                //Calculating the sum of the digits
                sum = a + b + c + d;

                //Showing the sum
                Console.WriteLine(" The sum of {0} + {1} + {2} + {3} = {4}", a, b, c, d, sum);

                //Reversing the number
                Console.WriteLine(" The number invested is: {0}{1}{2}{3}", d, c, b, a);

                //Showing the last digit in first position
                Console.WriteLine(" Showing the last digit in first position: {0}{1}{2}{3}", d, a, b, c);

                //Showing the exchange of the second and third digits
                Console.WriteLine(" Exchange of the second and third digits: {0}{1}{2}{3}", a, c, b, d);

            }
            else
            {
                Console.WriteLine(" The number its not valid"); 
            } 
            Console.ReadKey();
        }
    }
}
