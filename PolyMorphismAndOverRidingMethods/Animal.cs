using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismAndOverRidingMethods
{
    public class Animal
    {
        //virtual keyword is used to overwride the base class method in c#
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal has a sound!!");
        }
    }
}
