using System;

namespace Quest19
{
    class Program
    {
        static void Main(string[] args)
        {
            string Grade;
            Console.Write("Input Grade: ");
            Grade = Console.ReadLine();

            if (Grade == "E" || Grade == "e")
            {
                Console.WriteLine("You have chosen : Excellent");
            }else if (Grade == "V" || Grade == "v")
            {
                Console.WriteLine("You have chosen : Very Good");
            }else if (Grade == "G" || Grade == "g")
            {
                Console.WriteLine("You have chosen : Good");
            }else if (Grade == "A" || Grade == "a")
            {
                Console.WriteLine("You have chosen : Average");
            }else if (Grade == "F" || Grade == "f")
            {
                Console.WriteLine("You have chosen : Fail");
            }
        }
    }
}
