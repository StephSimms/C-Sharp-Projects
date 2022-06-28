using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> emp1 = new Employee<string>();
            emp1.Things = new List<string>() { "one hundred ", "two hundred ", "three hundred ", "four hundred ", "five hundred " };

            Employee<int> emp2 = new Employee<int>();
            emp2.Things = new List<int>() { 100, 200, 300, 400, 500 };

            for (int i = 0; i < emp1.Things.Count(); i++) 
            {
                Console.WriteLine(emp1.Things[i] + "and " + emp2.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
