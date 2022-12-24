using System;

namespace InterfaceInCSharp
{
     class Program 
    {
         static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.SleepSound();
            animal.MakeDogSound();
            Console.ReadLine();
        }

       
    }
}
