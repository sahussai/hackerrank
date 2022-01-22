using System;

namespace algorithms
{
    class Program
    {
        static void main(string[] args)
        {
            string time = "12:45:00PM";
            // Console.WriteLine(timeConversion(args[0]));
            Console.WriteLine(timeConversion(time));
        }

        public static string timeConversion(string s)
        {
            string[] split = s.Split(':');
            int hours = int.Parse(split[0]);
            int minutes = int.Parse((split[1]));
            int seconds = int.Parse(split[2].Substring(0,2));
            
            string AM_PM = split[2].Substring(2,2);
            // Console.WriteLine(AM_PM);
            
            string strHours = "";
            
            if (AM_PM == "AM")
            {
                if (hours == 12)
                {
                    strHours = "00";
                }
                else if (hours > 9)
                {
                    strHours = String.Concat("0", hours.ToString()); 
                }
                else
                {
                    strHours = s.Substring(0,2);
                }
            }
            else 
            {
                if (hours == 12)
                {
                    //don't add 12
                    strHours = hours.ToString();
                }
                else
                {
                    strHours = (hours + 12).ToString();
                }
            }
            
            return String.Concat(strHours, s.Substring(2, s.Length - 4));
        }

    }
}
