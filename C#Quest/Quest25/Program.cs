using System;

namespace Quest25
{
    class Program
    {
        static void Main(string[] args)
        {
            double Integer1;
            double Integer2;

            Console.Write("Enter the first Integer : ");
            Integer1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second Integer : ");
            Integer2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Here are the options:" +"\n" + "1-Addition."+"\n" +"2-Substraction."+"\n" +"3-Multiplication."+"\n" +"4-Division."+"\n" +"5-Exit.");
            double opt;
            opt = Convert.ToDouble(Console.ReadLine());

            if(opt == 1)
            {
                double Calculation;
                Calculation = Integer1 + Integer2;
                Console.WriteLine("The Addition of " + Integer1 + " and " + Integer2 + " is: " + Calculation);
            }else if(opt == 2)
            {
                double Calculation;
                Calculation = Integer1 - Integer2;
                Console.WriteLine("The Substraction of " + Integer1 + " and " + Integer2 + " is: " + Calculation);
            }else if(opt == 3)
            {
                double Calculation;
                Calculation = Integer1 * Integer2;
                Console.WriteLine("The Multiplication of " + Integer1 + " and " + Integer2 + " is: " + Calculation);
            }else if(opt == 4)
            {
                double Calculation;
                Calculation = Integer1 / Integer2;
                Console.WriteLine("The Division of " + Integer1 + " and " + Integer2 + " is: " + Calculation);
            }else if(opt == 5)
            {
                Console.WriteLine("Press Enter to Exit");
                Console.ReadLine();
            }
        }
    }
}
