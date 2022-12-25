using System;

namespace EnumsInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Level level = Level.Easy;
            Console.WriteLine(level);

            //by default the first value of the enum starts from 0
            // enum{ Easy,Hard,Medium } here Easy will by default have 0; Hard will have 1; Medium will have 2
            //To access the numeric value of the enum specify the variable name in int

            Console.WriteLine((int) level); //output is 3


            
        }
    }
}
