using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Firstdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2022;
            string month = "sept";
            float percentage = 89.56f;
            double a = 78.67;
            //using + sign
            Console.WriteLine("current yeat is " + year + "current month is " + month);
            //using placeholder
            Console.WriteLine("current year is {0} and current month is {1}", year, month);
            //using interpolation
            Console.WriteLine($"current year is {year}and month is {month}");
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(percentage);
            
            
        }
    }
}
