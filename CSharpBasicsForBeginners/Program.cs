using CSharpBasicsForBeginners.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsForBeginners
{
    class Program
    {

        static void Main(string[] args)
        {
            var matt = new Person();
            matt.FirstName = "Matt";
            matt.LastName = "Sharp";
            matt.Introduce();
            Console.ReadLine();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
