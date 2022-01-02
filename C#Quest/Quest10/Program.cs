using System;

namespace Quest10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Math;
            double Physics;
            double Chemitry;

            Console.Write("Input the marks obtained in Mathematics :");
            Math = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics :");
            Physics = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry :");
            Chemitry =Convert.ToDouble(Console.ReadLine());

            double AverageScore;
            AverageScore = 49.9;

            if (Math >= AverageScore && Physics >= AverageScore && Chemitry >= AverageScore)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
