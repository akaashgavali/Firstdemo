//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Firstdemo
//{
//    internal class Armstronghw3
//    {
//        static void Main(string[] args)
//        {
//            int num;
//            int result ;
//            int sum=0;
//            int rem;
//            Console.WriteLine("enter a number");
//             num = Convert.ToInt32(Console.ReadLine());

//            result = num;

//            while(num>0)
//            {
//                rem = num % 10;
//                sum = sum + rem * rem * rem;
//                num = num / 10;
//            }
//            if(result==sum)
//            {
//                Console.WriteLine("Armstrong number");
//            }
//            else
//            {
//                Console.WriteLine("Not Armstrong number");
//            }
//        }

//    }
//}
