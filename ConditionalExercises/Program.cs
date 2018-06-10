using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("You entered a valid number");
            }
            else
            {
                Console.WriteLine("What's wrong with you, I said between 1 and 10!");
            }
                
            Console.Read();
            Console.WriteLine("*******************************************************");
            int testOne = 340;
            int testTwo = 45;

            Console.WriteLine(Max(testOne, testTwo));


            Console.Read();
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Please enter the speed limit.");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter car speed.");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int mphPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / mphPerDemeritPoint;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"Demerit points: {demeritPoints}");
                }
                    
            }
            Console.Read();

        }


        public static int Max (int numberOne, int numberTwo)
        {
            return (numberOne > numberTwo) ? numberOne : numberTwo;
        }
    }
}
