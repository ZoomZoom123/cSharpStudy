using System;

namespace CSharpFundamentals
{
    public class ControlFlow

    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion");
                    break;

                default:
                    Console.WriteLine("What season is it?");
                    break;

            }
        }
    }
}
