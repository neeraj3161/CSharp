using System;

namespace InheritanceInCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //base clase is the parent class
            //child class is the derived class
            //to inherit the class use the : symbol
            //here is when sealed class comes into picture, if you dont want other class to inherit parent class use sealed identifier
            //calling the derived class
            Casper casper = new Casper();
            casper.BarkSound();
            //below method is called using multiple inheritance
            casper.Kingdom();
            Console.ReadLine();

        }
    }
}
