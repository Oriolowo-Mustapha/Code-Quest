using System;

namespace Quest16
{
    class Program
    {
        static void Main(string[] args)
        {
            char word;
            Console.Write("Enter Any Alphabet to check: ");
            word = Convert.ToChar(Console.ReadLine());
            
                switch (word)
                {
                    case 'a':
                        Console.WriteLine("It is a Vowel");
                        break;
                    case 'e':
                        Console.WriteLine("It is a Vowel");
                        break;
                    case 'i':
                        Console.WriteLine("It is a Vowel");
                        break;
                    case 'o':
                        Console.WriteLine("It is a Vowel");
                        break;
                    case 'u':
                        Console.WriteLine("It is a Vowel");
                        break;
                    default:
                        Console.WriteLine("It is a Consonant");
                        break;
                }
        }
    }
}
