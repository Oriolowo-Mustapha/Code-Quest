using System;

namespace Quest24
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.Write("Enter your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                double radius;
                double Calculation;

                Console.Write("Enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Calculation = 3.14 * radius * radius;
                Console.WriteLine("The Area of the circle  is: " + Calculation);
            }else if (choice == 2)
            {
                double Lenght;
                double Lenght2;

                Console.Write("Enter the first lenght : ");
                Lenght =  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Second lenght : ");
                Lenght2 =  Convert.ToDouble(Console.ReadLine());
                double Calculation;
                Calculation = Lenght * Lenght2;
                Console.WriteLine("The area of the square is: " + Calculation);
            }else if (choice == 3)
            {
                double Lenght;
                double breath;

                Console.Write("Enter the first lenght : ");
                Lenght =  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the breath : ");
                breath =  Convert.ToDouble(Console.ReadLine());
                double Calculation;
                Calculation = Lenght * breath;
                Console.WriteLine("The area of the rectangle is: " + Calculation);
            }else if (choice == 4)
            {
                double basep;
                double height;

                Console.Write("Enter the base : ");
                basep=  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height : ");
                height =  Convert.ToDouble(Console.ReadLine());
                double Calculation;
                Calculation = basep * height;
                Console.WriteLine("The area of the parallelogram is: " + Calculation);
            }else if (choice == 5)
            {
                double basep;
                double height;

                Console.Write("Enter the base : ");
                basep=  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height : ");
                height =  Convert.ToDouble(Console.ReadLine());
                double Calculation;
                Calculation = 0.5 * basep * height;
                Console.WriteLine("The area of the rigth angled triangle is: " + Calculation);
            }else if (choice == 6)
            {
                double a;
                double b;
                double height;

                Console.Write("Enter the parallel lines a : ");
                a =  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the parrallel lines b : ");
                b =  Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height : ");
                height =  Convert.ToDouble(Console.ReadLine());
                double Calculation;
                Calculation =  0.5 *(a + b) * height;
                Console.WriteLine("The area Trapezium is: " + Calculation);
            }
        }
    }
}
