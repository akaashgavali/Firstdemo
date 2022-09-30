using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstdemo
{
    internal class Relationalop1
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10;
            bool c = a == b;
            Console.WriteLine(c);
            bool d = a <= b;
            Console.WriteLine(d);
            bool e = a >= b;
            Console.WriteLine(e);
            bool f = a != b;
            Console.WriteLine(f);
        }
    }
}
