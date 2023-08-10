using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(3));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "sunday";
                    break;

                case 1:
                    dayName = "monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                default:
                    dayName = "Invalid Day number";
                    break;
            }
            return dayName;
        }


            
            
    }
}
