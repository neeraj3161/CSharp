using System;

namespace nullableObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValueTypes- int, float, double, structs, enums etc
            //Reference - Interface, Class, delegates, arrays

            //To make calue types nullable use ?

            
                int? i = 0;
                i = null;
                Console.WriteLine(i);
                Console.ReadKey();
            
        }
    }
}
