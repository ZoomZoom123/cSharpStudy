using System;

namespace CSharpFundementals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
}
