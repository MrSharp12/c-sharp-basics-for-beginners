using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];//or
            //var numbers = new int[3]
            //compiler knows its an array, no need for type or []

            numbers[0] = 1; //setting index 0 to 1

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);// since this wasn't initialized, it is set to the default of its type
            Console.WriteLine(numbers[2]);
            Console.ReadLine();

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);//same in this case, default is false
            Console.WriteLine(flags[2]);
            Console.ReadLine();

            //example of object initialization syntax
            //this way intializes during declaration
            var names = new string[3] {"Michael Myers", "Freddy Krueger", "Jason Voorhees" };
        }
    }
}
