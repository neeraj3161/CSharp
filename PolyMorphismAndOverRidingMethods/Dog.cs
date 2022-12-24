using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismAndOverRidingMethods
{
    public class Dog:Animal
    {
        public override void MakeSound()
        {
            //base.MakeSound() will print the method of the base class
           // base.MakeSound();
            Console.WriteLine("Wuhh Wuhh!!");
        }
    }
}
