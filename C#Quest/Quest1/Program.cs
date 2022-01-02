using System;

namespace Quest1
{
    class Program
    {
        static void Main(string[] args)
        {
           int Num1;
           int Num2;
           Console.Write("Input 1st number: ");
           Num1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Input 2nd number: ");
           Num2 = Convert.ToInt32(Console.ReadLine());

           if(Num1 == Num2)
           {
               Console.WriteLine(Num1 + " and " + Num2 + " are equal.");
           }else if (Num1 != Num2)
           {
                Console.WriteLine(Num1 + " and " + Num2 + " are not equal.");   
           }
        }
    }
}
