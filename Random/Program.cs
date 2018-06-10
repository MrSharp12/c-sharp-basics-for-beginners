using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //simulating a random password generator
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));//(char)casts number to a character
            }
            Console.Read();
        }
    }
}
