using System;

namespace Quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());

            int Checkleap;
            Checkleap = year % 4;
            if(Checkleap == 0)
            {
                Console.WriteLine(year + " is a Leap year");
            }else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        

        }
    }
}
