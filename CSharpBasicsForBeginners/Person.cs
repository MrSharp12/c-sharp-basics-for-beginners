using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsForBeginners
{
    public class Person
    {
        public string FirstName { get; set; }//keep in mind, for production do we want getters or setters to be public...
        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.");
        }
    }
}
