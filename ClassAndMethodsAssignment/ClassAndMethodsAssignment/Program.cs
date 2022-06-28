using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssignment
{
    //class Program
    //{
    //    static void Main(string[] args)
    //{
    //Part 1
    //Class1 obj1 = new Class1();

    //Console.WriteLine("Please type a number from 25-100");
    //int userInp = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Your number plus 25 equals:  " + obj1.intadd(userInp));


    //Console.WriteLine("Enter a decimal number to convert to an integer.");
    //decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
    //Console.WriteLine("Your decimal number as an integer is " + obj1.decToInt(userDecimal));

    //Console.WriteLine("Please enter a string value that will convert to an integer.");
    //string userString = Console.ReadLine();
    //Console.WriteLine("Your string as an integer is " + obj1.stringToInt(userString));

    //Console.ReadLine();



    //Part 2

    //twoIntOperator sumObj = new twoIntOperator();

    //Console.WriteLine("Please enter a number from 1 - 100.");
    //int intOne = Convert.ToInt32(Console.ReadLine());

    //try
    //{
    //    Console.WriteLine("Please enter another number from 1 - 100. Or you can leave this blank.");
    //    int intTwo = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Your two numbers added together equal " + sumObj.twoIntMethod(intOne, intTwo));
    //}
    //catch (FormatException)
    //{
    //    Console.WriteLine("The only number you entered is " + intOne);
    //}
    //finally
    //{
    //    Console.ReadLine();
    //}



    //Part 3




    //class Program
    //{ 
    //    static void Main(string[]args)
    //    {
    //        intvoid obj = new intvoid();

    //        obj.intvoidd(1000, 2000);
    //        Console.ReadLine();
    //    }

    //}


    //Class and Method Assignment Divide

    class Program
    {
        static void Main(string[] args)
        {
            Divider half = new Divider();
            Console.WriteLine("Please enter a number to be divided in half.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int dBase;

            half.halver(userInput);
            half.halver(out dBase, userInput, 2);


            Console.ReadLine();
        }
        

    }
    
}
