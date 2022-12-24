using System;

namespace classesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //here we will see how classes are created in c#

            //instantiating the defined class

            User u = new User();
            //using the c# properties it first sets the name and then gets it
            u.name = default(string);
            //now by default the name will be instantiated with a pre defined name variable but u can always over right it 
            Console.WriteLine(u.Sum(26,26));
            Console.ReadLine();


        }
    }
}
