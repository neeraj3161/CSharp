using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceInCSharp
{
    class Animal : IAnimal , IDog
    {
        public void MakeDogSound()
        {
            Console.WriteLine("Wuhh Wuhhh!!!");
        }

        public void MakeSound()
        {
            Console.WriteLine("This animal makes a sound");
        }

        public void SleepSound()
        {
            Console.WriteLine("zzzzz zzzz zzzz!!!");

        }
    }
}
