using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some random characters");
            var characters = Console.ReadLine();
            string newString = string.Empty;
            var counter = 1;
            foreach (char a in characters)
            {
                for (int i = 0; i < counter; i++)
                {
                    newString += a;
                }
                newString += "-";
                counter++;
            }
            Console.WriteLine($"Here is the new string {newString.TrimEnd('-')}");
        }
    }
}
