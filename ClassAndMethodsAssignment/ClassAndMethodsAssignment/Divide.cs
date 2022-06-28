using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssignment
{
    class Divider
    {

        public void halver(int x);
            {
            int halved = x / 2;
        Console.WriteLine("Your number divided in half is " + halved + ".");
            }

    public void halver(out int divbase, int input, int times = 1)
    {
        divbase = 2;
        int half2 = input / (divbase * times);
        Console.WriteLine("Your number in half " + times + " times is " halved2);
    }
}


