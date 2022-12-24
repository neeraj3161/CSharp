using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceInCSharp
{
    public class Dog:AnimalKingdom
    {
        public string Breed { get; set; }

        private bool DoesBark = true;

        //we will also use encapsulation here

        public void BarkSound()
        {
            switch (Breed)
            {
                case "german shepard":
                    Console.WriteLine("Wooo Woooo!!!");
                    break;
                case "golder retriever":
                    Console.WriteLine("Wuhh Wuhh!!");
                    break;
                default:
                    Console.WriteLine("Bread Sound not known");
                    break;
            }


        }

    }


}

