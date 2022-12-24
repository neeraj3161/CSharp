using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionInCSharp
{
    public abstract class Animal
    {
        //below is the abstract method that cannot be declared so you cannot use {//code} it needs to be decalared from the derived class where it is inherited
        public abstract void MakeSound();

        public static void SleepSound()
        {
            Console.WriteLine("zzz zzzz zzzzzzz!!!!");
        }
        
    }
}
