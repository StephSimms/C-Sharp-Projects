using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 819.375m;

            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
