using System;

namespace Quest20
{
    class Program
    {
        static void Main(string[] args)
        {
            int DayNum;

            Console.Write("Enter Day Number Ranging from 0-6: ");
            DayNum = Convert.ToInt32(Console.ReadLine());

            if (DayNum == 0)
            {
                Console.WriteLine("Sunday");
            }else if(DayNum == 1)
            {
                Console.WriteLine("Monday");
            }else if(DayNum == 2)
            {
                Console.WriteLine("Tuesday");
            }else if(DayNum == 3)
            {
                Console.WriteLine("Wednesday");
            }else if(DayNum == 4)
            {
                Console.WriteLine("Thursday");
            }else if(DayNum == 5)
            {
                Console.WriteLine("Friday");
            }else if(DayNum == 6)
            {
                Console.WriteLine("Sarturday");
            }else
            {
                Console.WriteLine("We only have seven day in the week. Invalid Day Number");
            }
        }
    }
}
