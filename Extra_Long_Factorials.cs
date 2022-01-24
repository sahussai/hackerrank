using System;
using System.Numerics;

namespace Extra_Long_Factorials
{
    class Extra_Long_Factorials
    {
        public static void main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine(factorial(25));
        }

        public static BigInteger factorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
               return (n * factorial(n-1));
            }
        }
    }
}