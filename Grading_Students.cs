using System;
using System.Collections.Generic;

namespace Grading_Students 
{
    class Grading_Students
    {
        public static void main()
        {
            Console.WriteLine("round is {0}", roundUpFive(50.001));
            List<int> grades = new List<int>() {73, 67, 38, 33};
            
            var rounded = gradingStudents(grades);

            foreach(int grade in rounded)
            {
                Console.WriteLine(grade);
            }

        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> nums = new List<int>();

            foreach(int grade in grades)
            {
                if (grade >= 38)
                {
                    int roundedGrade = roundUpFive(grade);
                    if (roundedGrade - grade < 3)
                    {
                        nums.Add(roundedGrade);
                    }
                    else
                    {
                        nums.Add(grade);
                    }
                }
                else
                {
                    nums.Add(grade);
                }
            }
            
            return nums;
        }

        public static int roundUpFive(double num)
        {
            return (int)Math.Ceiling(num / 5) * 5;
        }
    }

}