using System;

namespace PolyMorphismAndOverRidingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
            Console.ReadLine();
        }
    }
}
