using System;
namespace CSharpFundamentals
{
    public class IterationStatements
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
