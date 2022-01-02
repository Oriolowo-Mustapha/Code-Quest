using System;

namespace Quest6
{
    class Program
    {
        static void Main(string[] args)
        {
            double integer;
            int n;

            Console.Write("Enter any integer: ");
            integer = Convert.ToDouble(Console.ReadLine());
            if (integer != 0)
            {
                if (integer > 0 )
                {
                    n = 1;

                }else
                {
                    n = -1;
                }
            }else
            {
                n = 0;
            }
            Console.WriteLine("The value of integer is = " + integer);
            Console.WriteLine("The value of n is = " + n);
            
        }
    }
}
