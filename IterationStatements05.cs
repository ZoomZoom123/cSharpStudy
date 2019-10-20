using System;
namespace CSharpFundamentals
{
    public class IterationStatements
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@Echo: " + input);
            }
        }
    }
}
