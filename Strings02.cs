using System;

namespace CSharpFundamentals
{
    public class Strings02
    {
        static void Main(string[] args)
        {
            var fullName = "Mino Smith ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Mino", "Minotchka"));

            if (string.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            if (string.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }

            if (string.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invlaid");
            }

            var str = "30";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }

    }
}
