using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{ 
    class CouponNumber
    {
        private const int TOTAL_COUPON = 5;
        public static void GenerateCoupon()
        {
            //local variable to check number of coupons and array to store distinct coupons
            int numOfCoupons = 0;
            int i = 0;
            int no_Repeat = 1;
            int generateTime = 0;
            int[] coupon = new int[5];

            //creating object for random class
            Random random = new Random();

            //check till total number of distinct coupon is received 
            while (numOfCoupons < TOTAL_COUPON)
            {

                {
                    no_Repeat = 1;
                    i = 0;
                    int tempCoupon = random.Next(1, 12);
                    Console.WriteLine("" + tempCoupon);

                    while (i <= numOfCoupons)
                    {
                        //check the coupon is  distinct or not
                        if (coupon[i] == tempCoupon)
                        {
                            no_Repeat = 0;
                            break;
                        }
                        i++;
                    }
                    generateTime++;
                    if (no_Repeat == 1)
                    {
                        coupon[numOfCoupons] = tempCoupon;
                        numOfCoupons++;
                    }
                }
                //displays random number needed to generate 5 distinct coupon
                Console.WriteLine("Number of Time required to generate 5 distict coupon:" + generateTime);

                //displays the distinct coupon
                Console.WriteLine("The Distinct 5 coupons are :");
                foreach (int n in coupon)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
