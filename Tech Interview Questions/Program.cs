using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number = int.Parse(Console.ReadLine());

            int divByThree = number % 3;
            int divByFive = number % 5;

            if (divByFive == 0 && divByThree == 0)
            {
                Console.WriteLine("Fizz Buzz");
              }
            else if (divByFive == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (divByThree == 0)
            {
                Console.WriteLine("Fizz");             
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5");
            }



            
        }
    }
}
