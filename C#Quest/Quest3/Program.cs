using System;

namespace Quest3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("It is an positive number");
            }
            else
            {
                Console.WriteLine("It is an negative number");
            }
        }
    }
}
