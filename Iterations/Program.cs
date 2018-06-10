using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadLine();

            //for (var i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Console.Read();
            //Console.WriteLine("***********************************");

            //var name = "Glenn Danzig";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Console.Read();
            //Console.WriteLine("***********************************");

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //Console.Read();
            //Console.WriteLine("***********************************");

            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.Read();

            //while loop
            //better to use this when we don't know ahead of time
            //how many times you are going to do an iteration
            
            while (true)
            {
                Console.WriteLine("Type your name");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"@Echo: {input}");
                    continue;
                }
                    break;
            }

            Console.Read();
        }
    }
}
