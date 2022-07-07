using System;

namespace methods
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite subject?");

            string subject = Console.ReadLine();


            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is boring!");
                    break;
                case "science":
                    Console.WriteLine("Science is interesting!");
                    break;
                case "coding":
                    Console.WriteLine("Coding is the best!");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite!");
                    break;
                case "literature":
                    Console.WriteLine("Literature is the worst!");
                    break;
                default:
                    Console.WriteLine("Thats not a subject");
                    break;

            }
        }
    }
}

