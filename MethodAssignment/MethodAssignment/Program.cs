using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number: 10, 20, 30, 40, 50, 60");
            int userInp = Convert.ToInt32(Console.ReadLine());

            Class1 obj1 = new Class1();

            Console.WriteLine("Your number times 2 is:  " + obj1.intmultiply(userInp));
            Console.WriteLine("Your number divided by 2 is:  " + obj1.intdivide(userInp));
            Console.WriteLine("Your number minus 2 is:  " + obj1.intminus(userInp));
            Console.ReadLine();

            

        }
    }
}
