using System;

namespace Quest13
{
    class Program
    {
        static void Main(string[] args)
        {
            int Temp;

            Console.Write("Enter Temprature: ");
            Temp = Convert.ToInt32(Console.ReadLine());

            if (Temp < 0)
            {
                Console.WriteLine("Freezing Whether");
            }else if(Temp > 0 && Temp < 10)
            {
                Console.WriteLine("Very Cold Whether");
            }else if(Temp > 10 && Temp < 20)
            {
                Console.WriteLine("Cold Whether");
            }else if(Temp > 20 && Temp < 30)
            {
                Console.WriteLine("Normal Whether");
            }else if(Temp > 30 && Temp < 40)
            {
                Console.WriteLine("Hot Whether");
            }else if(Temp >= 40)
            {
                Console.WriteLine("Very Hot Whether");
            }
        }
    }
}
