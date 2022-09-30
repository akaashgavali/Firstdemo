using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstdemo
{
    internal class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            {
                Console.WriteLine("it is leap year");
            }
            else
            {
                Console.WriteLine("it is not leap yaer");
            }
        }

    }
}
