using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public int Age;
    }

    class ReferenceTypesAndValues2
    {
        static void Main(string[] args)
        {
            var number = 1;
            Incrememt(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Incrememt(int number)
        {

        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
