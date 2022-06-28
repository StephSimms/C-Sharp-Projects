using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Please enter a number: ");
            double userNum = Convert.ToDouble(Console.ReadLine());

            File.WriteAllText(@"C\:users\steph\OneDrive\Documents\Text.txt", ConvertToString(userNum));

            Console.WriteLine("Let's get your number from our files.");
            string retrieveNum = File.ReadAllText(@"C\:users\steph\OneDrive\Documents\Text.txt");
            Console.WriteLine($"Your number is {retrieveNum}.");
            Console.ReadKey();

        }
    }
}
