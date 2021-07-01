using System;

namespace LogicalProgramming
{
    class Program
    {
        static void Main(string[] args)
        { int Choice = 0;
            Console.WriteLine("welcome to LOGICAL PROGRAMMING!");
            Console.WriteLine("choose the program:");
            Console.WriteLine("1) Generating coupon:");


            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CouponNumber.GenerateCoupon();
                    break;
                // case 2:
                //   break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
