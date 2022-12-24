using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismAndOverRidingMethods
{
    public class Cat:Animal
    {
        public override void MakeSound()
        {
            //base.MakeSound(); will execute the base method and after that it will execute the override method
            //base.MakeSound();
            Console.WriteLine("Meow!!");
        }
    }
}
