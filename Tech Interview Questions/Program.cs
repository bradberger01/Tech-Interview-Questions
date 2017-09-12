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
            //Console.WriteLine("Give me a number!");
            //int number = int.Parse(Console.ReadLine());

            //int divByThree = number % 3;
            //int divByFive = number % 5;

            //if (divByFive == 0 && divByThree == 0)
            //{
            //    Console.WriteLine("Fizz Buzz");
            //  }
            //else if (divByFive == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else if (divByThree == 0)
            //{i

            //    Console.WriteLine("Fizz");             
            //}
            //else
            //{
            //    Console.WriteLine("This number is not divisible by 3 or 5");
            //}

            //print out all prime numbers that are less than 100 to the console. 0 and 1 are not prime numbers

            List<int> oneToHundred = new List<int> { 3, 5, 7 };
            Console.WriteLine(3);
            Console.WriteLine(5);
            Console.WriteLine(7);
            for(int i =2; i<=100; i++)
              
            {
                if(i % 2 != 0 && i % 3 !=0 && i % 7 !=0 && i % 5 !=0)
                {
                    
                    Console.WriteLine(i);
                }
            }
            //OR

            bool isPrime = true;

            for(int i =2; i <= 100; i++)
            {
                for(int j = 2; j < 100; j++)
                {
                    if(i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
                isPrime = true;

            }




        }
    }
}
