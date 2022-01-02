using System;

namespace Quest7
{
    class Program
    {
        static void Main(string[] args)
        {
           double height;
           Console.Write("Enter Height: ");
           height = Convert.ToDouble(Console.ReadLine());
            double averageheight;
            averageheight = 150.0;
            if (height <= averageheight)
            {
                Console.WriteLine("The person is Dwarf");
            }else if(height >= averageheight && height < 165.0)
            {
                Console.WriteLine("The person is of normal height");
            }else if(height >= 165.0 && height < 195.0)
            {
                Console.WriteLine("The person is Taller");
            }else
            {
                Console.WriteLine("The person is of abnormal height");
            }
        }
    }
}
