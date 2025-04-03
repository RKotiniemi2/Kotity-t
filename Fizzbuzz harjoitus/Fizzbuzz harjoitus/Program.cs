//Tehtävä on tehty harjoitukseksi huomiseen c# pistariin. Tehtävä oli ratkoa fizzbuzz pähkinä.

using System;

namespace Fizzbuzz_harjoitus
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            FizzBuzz();

            Console.ReadLine();
        }

        static void FizzBuzz()
        {
            for (int x = 1; x <= 100; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (x % 3 == 0 )
                    Console.WriteLine("Fizz");

                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                    Console.WriteLine(x);





                   
            }
        }
    }
}
