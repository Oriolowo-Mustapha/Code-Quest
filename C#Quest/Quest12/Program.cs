using System;

namespace Quest12
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollNum;
            string Studentname;
            double Physics;
            double Chemistry;
            double ComputerApplication;
            

            Console.Write("Input the Roll Number of the student: ");
            rollNum = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Input the Name of the Student :");
            Studentname = Console.ReadLine();

            Console.Write("Input the marks of Physics :");
            Physics = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input th emarks for Chemistry: ");
            Chemistry = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input the mark of Computer Application: ");
            ComputerApplication = Convert.ToDouble(Console.ReadLine());

            double AverageScore;
            double TotalScore;

            Console.WriteLine("+---------+-------+----------+------------+");
            Console.WriteLine("Roll No : " + rollNum);
            Console.WriteLine("Name of Student : " + Studentname);
            Console.WriteLine("Marks in Physics : " + Physics);
            Console.WriteLine("Marks in Chemistry : " + Chemistry);
            Console.WriteLine("Marks in Computer Application : " + ComputerApplication);

            AverageScore = (Physics  + Chemistry + ComputerApplication) / 3;
            Console.WriteLine("Percentage: " + AverageScore);
            TotalScore = Physics  + Chemistry + ComputerApplication;
            Console.WriteLine("Total Score: " + TotalScore);

            if (AverageScore >= 80)
            {
                Console.WriteLine("Division: First");
            }else if (AverageScore >= 60)
            {
                Console.WriteLine("Division: Second");
            }else if (AverageScore >= 50 && AverageScore < 60)
            {
                Console.WriteLine("Division: Pass");
            }else
            {
                Console.WriteLine("Division Fail");
            }

        }
    }
}
