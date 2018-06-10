using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // if/else
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Good morning.");//you can have this outside of {}, but is best practice to use them
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // terniary operator

            bool isGoldCustomer = true;
            //using float because integers can't hold decimals
            //lower case f is attached to the value to designate float, error if not there
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            //switch statement
            var season = SeasonsEnum.Autumn;

            switch (season)
            {
                case SeasonsEnum.Autumn:
                    Console.WriteLine("It's Autumn.");
                    break;

                case SeasonsEnum.Summer:
                case SeasonsEnum.Spring:
                    Console.WriteLine("Great weather!");
                    break;

                case SeasonsEnum.Winter:
                    Console.WriteLine("It's Winter.");
                    break;

                default:
                    Console.WriteLine("That's not a season!");
                    break;
            }


            Console.Read();
        }
    }
}
