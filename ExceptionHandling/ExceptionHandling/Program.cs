using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Don't be an idiot, type a whole number.");
        //    return;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}




        //Exception Assignment 
        //try
        //{

        //    List<int> intList = new List<int>() { 100, 75, 50, 25, 5 };
        //    Console.WriteLine("Pick a number to divide each number in the list.");
        //    int userNum = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < intList.Count; i++)
        //        {
        //            int listDivInp = intList[i] / userNum;
        //            Console.WriteLine(listDivInp);
        //        }
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please choose a positive whole number.");
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please do not try to divide by zero.");
        //}
        //finally

        //{
        //    Console.ReadLine();
        //}


        //Exception Handling Assignment Module 8


        try
        {
            Console.WriteLine("What is your age?");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("That's awesome, you are: " + userNum);
            Console.ReadLine();
        }

        catch

        {
            Console.WriteLine("Don't be silly, entering zero or negative numbers will not work!");
            return;
        }
        catch (Exception)
        { 
               Console.WriteLine("Ooops, an error occurred.  Please contact your system administrator.");
            return;    
        }
            
        
        
            Console.ReadLine();
        





        
    }



