//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//                                     //find out given number is palindrome or not
//namespace Firstdemo
//{
//    internal class homework4
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("enter a number");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int result = num;
//            int rem;
//            int reverse = 0;
//            while (num > 0)
//            {
//                rem = num % 10;
//                reverse = reverse * 10 + rem;
//                num = num / 10;
//            }
//            if (result == reverse)
//            {
//                Console.WriteLine($"{result} is a palindrome number");
//            }
//            else
//            {
//                Console.WriteLine($"{result} is not palindrome number");
//            }
//        }
//    }
//}

