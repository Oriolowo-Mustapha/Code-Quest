using System;

namespace Quest14
{
    class Program
    {
        static void Main(string[] args)
        {
            double Angle1;
            double Angle2;
            double Angle3;
            double add;

            

            Console.Write("Input the first angle of the triangle: ");
            Angle1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the second angle of the triangle: ");
            Angle2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the third angle of the triangle: ");
            Angle3 = Convert.ToDouble(Console.ReadLine());

            add = Angle1 + Angle2 + Angle3;

            if (add > 180.00)
            {
                Console.WriteLine("The sum of all the numbers is greater thean 180 Degrees");
            }

// Equilateral Triangle
            if (Angle1 == Angle2 && Angle1 ==  Angle3)
            {
                Console.WriteLine("This is an Eqilateral Tringle");
            }else if(Angle2 == Angle1 && Angle2 ==  Angle3)
            {
                Console.WriteLine("This is an Eqilateral Tringle");
            }else if(Angle3 == Angle2 && Angle3 ==  Angle1)
            {
                Console.WriteLine("This is an Eqilateral Tringle");
            }

// Isosceles Triangle

            if (Angle1 == Angle2 && Angle1 != Angle3)
            {
                Console.WriteLine("This is Isosceles Triangle");
            }else if(Angle1 == Angle3 && Angle1 != Angle2)
            {
                Console.WriteLine("This is Isosceles Triangle");
            }

            else if(Angle2 == Angle1 && Angle2 != Angle3)
            {
                Console.WriteLine("This is Isosceles Triangle");
            }else if(Angle2 == Angle3 && Angle2 != Angle1)
            {
                Console.WriteLine("This is Isosceles Triangle");
            }

            else if(Angle3 == Angle2 && Angle3 != Angle1)
            {
                Console.WriteLine("This is Isosceles Triangle");
            }else if(Angle3 == Angle1 && Angle3 != Angle2)
            {
                Console.WriteLine("This is Isosceles Triangle");
            }

            else if (Angle1 != Angle2 && Angle1 != Angle3)
            {
                Console.WriteLine("This is a Scalene Triangle");
            } else if (Angle1 != Angle3 && Angle1 != Angle2)
            {
                Console.WriteLine("This is a Scalene Triangle");
            } else if (Angle2 != Angle1 && Angle2 != Angle3)
            {
                Console.WriteLine("This is a Scalene Triangle");
            } else if (Angle2 != Angle3 && Angle2 != Angle1)
            {
                Console.WriteLine("This is a Scalene Triangle");
            } else if (Angle3 != Angle2 && Angle3 != Angle1)
            {
                Console.WriteLine("This is a Scalene Triangle");
            } else if (Angle3 != Angle1 && Angle3 != Angle2)
            {
                Console.WriteLine("This is a Scalene Triangle");
            }

            
        }
    }
}
