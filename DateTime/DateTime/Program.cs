using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Date & Time is:  "+DateTime.Now);

            Console.WriteLine("Enter a number of hours");
            int passHours = Int32.Parse(Console.ReadLine());

            Console.WriteLine("In " + passHours + " hours it will be " + DateTime.Now.AddHours(passHours));
            Console.ReadLine();


        }
    }
}
