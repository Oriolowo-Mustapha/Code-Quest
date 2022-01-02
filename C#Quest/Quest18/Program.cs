using System;

namespace Quest18
{
    class Program
    {
        static void Main(string[] args)
        {
            double Id;
            string Name;
            double unit;

            Console.Write("Customer Id: ");
            Id = Convert.ToDouble(Console.ReadLine());

            Console.Write("Customer Name: ");
            Name = Console.ReadLine();

            Console.Write("Input Unit Consumed: ");
            unit = Convert.ToDouble(Console.ReadLine());
            if (unit < 200)
            {
                double add;
                add  = unit * 2;

                Console.WriteLine("Amount Charges : @Rs.1.20: " + add);
            }

            else if (unit >= 200 && unit < 400)
            {
                double add;
                add  = unit * 2;

                Console.WriteLine("Amount Charges : @Rs.1.50: " + add);
            }else if (unit >= 400 && unit < 600)
            {
                double add;
                add  = unit * 2;

                Console.WriteLine("Amount Charges : @Rs.1.80: " + add);
            }else if (unit >= 600)
            {  
                double add;
                double sum;
                add  = unit * 2;
                sum  = add + 240.00;
                
                Console.WriteLine("Amount Charges : @Rs.2.00: 1600.00");
                Console.WriteLine("Net Amount Paid By the Customer : " + sum);
                
            }

        }
    }
}
