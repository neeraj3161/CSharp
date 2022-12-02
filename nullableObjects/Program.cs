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

            //same goes for other value types 

            bool? b = true;
            b = null;
            if (!b.HasValue) {
                //HasValue will check if there's any value
                try
                {
                    Console.WriteLine("Boolean type is " + b.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //We can also throw a custom exception
                    //this will throw a in windows exception
                    //throw new ArgumentException("pps we got a error here.", ex);

                }
            }

            //now we will assign a value to b

            bool c = b ?? true;
            //the above line says if b is null assign it true
            Console.WriteLine("Now c is "+c);
                Console.WriteLine(i);
                Console.ReadKey();
            
        }
    }
}
