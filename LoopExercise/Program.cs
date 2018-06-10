using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            //for (var i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.Read();
            //Console.WriteLine("*********************************");

            //exercise 2
            //var sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or ok to exit");
            //    var userInput = Console.ReadLine();

            //    if (userInput.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(userInput);
            //}

            //Console.WriteLine($"The sum of your numbers is {sum}");
            //Console.Read();

            //exercise three
            //Console.Write("Enter a number: ");
            //var number = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for (var i = 1; i <= number; i++)
            //     factorial *= i;

            //Console.WriteLine($"{number}! = {factorial}");
            //Console.Read();
            //Console.WriteLine("*********************************");

            //exercise 4
            //var number = new Random().Next(1, 11);

            //Console.WriteLine("Secret is " + number);
            //for (var i = 0; i < 4; i++)
            //{
            //    Console.Write("Guess the secret number: ");
            //    var guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        Console.Read();
            //        return;
            //    }
            //}

            //Console.WriteLine("You lost!");

            //Console.Read();

            //exercise 5
            Console.Write("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            //splits up the array
            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine($"Max is {max}.");
            Console.Read();


        }


    }
}
