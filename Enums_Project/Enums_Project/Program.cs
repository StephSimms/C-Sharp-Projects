using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is the current day of the week?");

                Weekday today = (Weekday)Enum.Parse(typeof(Weekday), Console.ReadLine());

                Console.WriteLine("The current day of the week is: " + today);
            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }

    public enum Weekday
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
        
    }

}
