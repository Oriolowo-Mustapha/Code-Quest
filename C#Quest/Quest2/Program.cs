using System;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
           int NUM ;
           Console.Write("Enter any number: ");
           NUM = Convert.ToInt32(Console.ReadLine());

           int Check;
           Check = NUM % 2;
           if (Check == 0)
           {
               Console.WriteLine("It is an Even number");
           }else
           {
               Console.WriteLine("It is an odd number");
           }
        }
    }
}
