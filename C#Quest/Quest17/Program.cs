using System;

namespace Quest17
{
    class Program
    {
        static void Main(string[] args)
        {
            double costPrice;
            double sellingPrice;

           Console.Write("Input your cost price: ");
            costPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input your selling price: ");
            sellingPrice = Convert.ToDouble(Console.ReadLine());

            if (sellingPrice > costPrice)
            {
                double profit;

            profit = costPrice - sellingPrice;

            Console.WriteLine("You can book your profit amount : " + profit);
            }else
            {
                double Loss;

            Loss = sellingPrice - costPrice;

            Console.WriteLine("You got a Loss amount : " + Loss);
            }

            

        }
    }
}


