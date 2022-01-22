using System;
using System.Collections.Generic;

namespace Apples_and_Oranges
{
    class Apples_and_Oranges
    {
        public static void Main()
        {
            Console.WriteLine("hello");
            List<int> apples = new List<int> {-2, 2, 1};
            List<int> oranges = new List<int> {5, -6};
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;

            countApplesAndOranges(s,t,a,b,apples,oranges);
        }

        // https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            List<int> appleLocations = fruitLanding(apples, a);
            List<int> orangeLocations = fruitLanding(oranges, b);

            int numApples = numOnHouse(appleLocations,s,t);
            int numOranges = numOnHouse(orangeLocations,s,t);

            Console.WriteLine(numApples);
            Console.WriteLine(numOranges);

        }

        public static List<int> fruitLanding(List<int> drops, int treeLocation)
        {
            List<int> adjustedCoords = new List<int>();
            
            foreach (int coord in drops)
            {
                adjustedCoords.Add(coord + treeLocation);
            }
            return adjustedCoords;
        }

        public static int numOnHouse(List<int> drops, int start, int end)
        {
            int counter = 0;

            foreach(int coord in drops)
            {
                if (coord >= start && coord <= end)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}