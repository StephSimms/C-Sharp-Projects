using System;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Test";
            person.LastName = "Testing";

            person.SayName(person.FirstName, person.LastName);

            Console.ReadLine();
        }
    }
}
