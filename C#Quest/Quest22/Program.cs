using System;

namespace Quest22
{
    class Program
    {
        static void Main(string[] args)
        {
            int MonthNum;
            Console.Write("Inout any month number: ");
            MonthNum = Convert.ToInt32(Console.ReadLine());

            if (MonthNum == 1)
            {
                Console.WriteLine("January");
            }else if (MonthNum == 2)
            {
                Console.WriteLine("Febuary");
            }else if (MonthNum == 3)
            {
                Console.WriteLine("March");
            }else if (MonthNum == 4)
            {
                Console.WriteLine("April");
            }else if (MonthNum == 5)
            {
                Console.WriteLine("May");
            }else if (MonthNum == 6)
            {
                Console.WriteLine("June");
            }else if (MonthNum == 7)
            {
                Console.WriteLine("July");
            }else if (MonthNum == 8)
            {
                Console.WriteLine("August");
            }else if (MonthNum == 9)
            {
                Console.WriteLine("September");
            }else if (MonthNum == 10)
            {
                Console.WriteLine("October");
            }else if (MonthNum == 11)
            {
                Console.WriteLine("November");
            }else if (MonthNum == 12)
            {
                Console.WriteLine("December");
            }else
            {
                Console.WriteLine("INVALID MONTH NUMBER");
            }
        }
    }
}
