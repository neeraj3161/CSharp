using System;

namespace AbstractionInCSharp
{
    public class Program : Animal
    {
         static void Main(string[] args)
        {
            //now if you try to call the abstract method direclty this will throw you a error
            //Animal animal = new Animal();
            // animal.SleepSound();

            //error message: Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0144  Cannot create an instance of the abstract type or interface 'Animal'	AbstractionInCSharp C:\Users\neera\OneDrive\Desktop\c#\classesInCSharp\AbstractionInCSharp\Program.cs	10	Active

            //so for the method to work we need to inherit the abstract class

            SleepSound();
        }

        //if you do not implement the abstract method it will throw u an error so the method which is not defined needs to be defined here
        public override void MakeSound()
        {
            Console.WriteLine("This animal makes a sound!!");
        }
    }
}
