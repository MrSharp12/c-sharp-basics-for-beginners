using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 3, 4, 67, 2, 12, 6 };

            //Length
            Console.WriteLine($"Length: {numbers.Length}");


            //IndexOf()
            var index = Array.IndexOf(numbers, 67);
            Console.WriteLine(index);


            //Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }


            //Sort
            Array.Sort(numbers);

            Console.WriteLine("Effect of sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            //Reverse
            Array.Reverse(numbers);

            Console.WriteLine("Effect of reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.Read();
        }
    }
}
