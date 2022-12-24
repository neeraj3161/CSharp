using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceInCSharp
{
    public class Casper : Dog
    {
        public Casper()
        {
            //breed is the setter we call it from the parent class
            Breed = "golder retriever";

        }
    }
}
