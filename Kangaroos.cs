using System;

namespace Kangaroos
{
    class Kangaroos
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine(kangaroo(0,3,4,1));
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int x1Pos = x1;
            int x2Pos = x2;
            int counter = 0;
            while (counter < 10000)
            {
                x1Pos += v1;
                x2Pos += v2;

                if (x1Pos == x2Pos)
                {
                    return "YES";
                }
                counter++;
            }
            return "NO";
        }

    }
}