using System;
namespace CSharpFundamentals
{
    public class IterationStatements
    {
        static void Main(string[] args)
        {
            var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
