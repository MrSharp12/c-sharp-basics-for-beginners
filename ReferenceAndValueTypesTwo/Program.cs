using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypesTwo
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            //this will be one because when you pass a variable as an arguement
            //to the Increment method, a copy of this variable is taken
            //and sent to the Increment method


            var person = new Person() { Age = 20 };//used object initialization
            MakeOld(person);
            Console.WriteLine(person.Age);
            //this will be 30 because it is pointing to the same object on the heap

            Console.ReadLine();
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
