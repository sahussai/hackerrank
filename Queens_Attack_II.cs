using System;
using System.Collections.Generic;

namespace Queens_Attack_II
{
    class Queens_Attack_II
    {
        public static void Main()
        {
            int rq = 3;
            int cq = 7;
            List<List<int>> right = Right(rq,cq,8);
            List<List<int>> topRight = TopRight(rq,cq,8);
            List<List<int>> up = Up(rq,cq,8);
            List<List<int>> topLeft = TopLeft(rq,cq,8);
            List<List<int>> left = Left(rq,cq,8);
            List<List<int>> bottomLeft = BottomLeft(rq,cq,8);
            List<List<int>> down = Down(rq,cq,8);
            List<List<int>> bottomRight = BottomRight(rq,cq,8);
            Console.WriteLine("heelo");



        }

        public static List<List<int>> TopRight(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (rq+i < 1 || cq+i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq + i, cq + i});
            }
            return attacks;
        }
        
        public static List<List<int>> TopLeft(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (rq+i < 1 || cq-i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq + i, cq - i});
            }
            return attacks;
        }
        
        public static List<List<int>> Up(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (rq+i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq + i, cq});
            }
            return attacks;
        }
        
        public static List<List<int>> Down(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (rq-i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq - i, cq});
            }
            return attacks;
        }
        
        public static List<List<int>> BottomRight(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (rq-i < 1 || cq+i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq - i, cq + i});
            }
            return attacks;
        }
        
        public static List<List<int>> BottomLeft(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (rq-i < 1 || cq-i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq - i, cq - i});
            }
            return attacks;
        }
        
        
        public static List<List<int>> Left(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (cq-i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq, cq - i});
            }
            return attacks;
        }
        public static List<List<int>> Right(int rq, int cq, int n)
        {
            List<List<int>> attacks = new List<List<int>>();

            for (int i = 1; i <= (n - rq); i++)
            {
                if (cq+i < 1)
                {
                    break;
                }
                attacks.Add(new List<int>{rq, cq + i});
            }
            return attacks;
        }
    }
}