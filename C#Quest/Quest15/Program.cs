using System;

namespace Quest15
{
    class Program
    {
        static void Main(string[] args)
        {
           double Angle1;
           double Angle2;
           double Angle3;

           Console.Write("Input the first angle: ");
           Angle1 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Input the Second angle: ");
           Angle2 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Input the Third angle: ");
           Angle3 = Convert.ToDouble(Console.ReadLine());

           double add;
           double Degree;

           add = Angle1 + Angle2 + Angle3;
           Degree = 180.00;

           if (add > Degree)
           {
               Console.WriteLine("THe Triangle is not valid");
           }else
           {
               Console.WriteLine("The triangle is Valid");
           }

        }
    }
}
