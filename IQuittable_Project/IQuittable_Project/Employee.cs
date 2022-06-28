using System;
using System.Collections.Generic;
using System.Text;

namespace IQuittable_Project
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public void SayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            
        }
    }
}
