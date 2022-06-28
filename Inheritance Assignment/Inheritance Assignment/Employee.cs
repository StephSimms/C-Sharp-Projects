using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment
{
    class Employee : Person
    {
        public int ID { get; set; }
        public void SayName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }
}
