using System;

namespace Quest23
{
    class Program
    {
        static void Main(string[] args)
        {
           int MonthNum;
           string January =  "31 days";
            string Febuary = "28 or 29 days";
            string March =   "31 days";
            string April = "30 days";
            string May = "31 days";
            string June = "30 days";
            string July = "31 days";
            string August = "31 days";
            string September = "30 days";
            string October = "31 days";
            string November = "30 days";
            string December = "31 days";

           Console.Write("Input Month Number: ");
           MonthNum = Convert.ToInt32(Console.ReadLine());

           if (MonthNum == 1)
           {
               Console.WriteLine("The Month has " + January);
           }else if (MonthNum == 2)
           {
               Console.WriteLine("The Month Has " + Febuary);
           }else if (MonthNum == 3)
           {
               Console.WriteLine("The Month Has " + March);
           }else if (MonthNum == 4)
           {
               Console.WriteLine("The Month Has " + April);
           }else if (MonthNum == 5)
           {
               Console.WriteLine("The Month Has " + May);
           }else if (MonthNum == 6)
           {
               Console.WriteLine("The Month Has " + June);
           }else if (MonthNum == 7)
           {
               Console.WriteLine("The Month Has " + July);
           }else if (MonthNum == 8)
           {
               Console.WriteLine("The Month Has " + August);
           }else if (MonthNum == 9)
           {
               Console.WriteLine("The Month Has " + September);
           }else if (MonthNum == 10)
           {
               Console.WriteLine("The Month Has " + October);
           }else if (MonthNum == 11)
           {
               Console.WriteLine("The Month Has " + November);
           }else if (MonthNum == 12)
           {
               Console.WriteLine("The Month Has " + December);
           }else
           {
               Console.WriteLine("Invalid Month Number");
           }
        }
    }
}
