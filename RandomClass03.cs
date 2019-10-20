using System;
namespace CSharpFundamentals
{
    public class RandomClass
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));
            }
        }
    }
}
