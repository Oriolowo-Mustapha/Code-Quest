using System;

namespace Quest8
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1;
            int integer2;
            int integer3;
            Console.Write("Enter 1st integer: ");
            integer1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd integer: ");
            integer2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3rd integer: ");
            integer3 = Convert.ToInt32(Console.ReadLine());

            if (integer1 >= integer2 && integer1 >= integer3)
            {
                Console.WriteLine("The 1st integer is the greatest");
            }
            else if(integer2 >= integer3 && integer2 >= integer1 )
            {
                Console.WriteLine("The 2nd number is the greatest");
            }
            else if(integer3 >= integer1 && integer3 >= integer2)
            {
                Console.WriteLine("The 3rd number is the greatest");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
