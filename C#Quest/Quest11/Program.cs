using System;

namespace Quest11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;

            double d, x1, x2;

            Console.Write("Input the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;

            if(d == 0)
            {
                Console.WriteLine("Both roots are equal.");
                x1 = -b/(2.0 * a);
                x2 = x1;
                Console.WriteLine("First Root Root1 = {0}\n", x1);
                Console.WriteLine("Second Root Root2 = {0}\n", x2);
            }
            else if(d > 0 )
            {
                Console.WriteLine("Both root are real and diff-2");

                x1 = (-b + Math.Sqrt(d))/ (2 * a);
                x2 = (-b - Math.Sqrt(d))/ (2 * a);

                Console.WriteLine("First Root Root1 = {0}\n", x1);
                Console.WriteLine("Second Root Root2 = {0}\n", x2);
            }else
            {
                Console.WriteLine("Root are Imaginary\nNo solution");
            }
        }
    }
}
