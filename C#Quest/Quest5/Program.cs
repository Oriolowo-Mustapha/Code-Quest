using System;

namespace Quest5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Hi these is vote eligibler Enter your age to chek whether you are eligible to vote");
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            int eligibleAge;
            eligibleAge = 18;
            if (age >= eligibleAge)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You not are eligible for casting your vote.");
            }
        }
    }
}
