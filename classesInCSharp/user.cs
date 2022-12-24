using System;
using System.Collections.Generic;
using System.Text;

namespace classesInCSharp
{
    public class User
    {

        //access modifiers in class
        //internal ---> accessible from the assembly they are derived in
        //sealed ---> cannot be inherited by other classes Once a class is sealed, you cannot use the extends or implements keywords to derive a class from it or implement an interface.

        //private ---> are only accessable from the class they are derived in
        //public ---> are accessable from anywhere within the program
        //protected ---> are accessable from the defined/derived class or the inherited class
        //protected internal ----> are only accesable from the assembly they are derived and the class they are declared in
        //below are how you create a class members in c#
        public string name { get; set; } 
        public string email { get; set; }
        
        public int age { get; set; }

        public User() {
            //creating a constructor for the class
            this.name = "Hello";
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
        

    }
}
