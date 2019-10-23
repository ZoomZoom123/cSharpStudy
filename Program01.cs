using System;

namespace CSharpFundementals

{
    public class Program01
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);


            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - 1] = name[i - 1];
            }

            return new string(array);
        }
    }
    
}
