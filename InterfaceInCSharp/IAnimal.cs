using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceInCSharp
{
     interface IAnimal
    {
        //we cannot define a field inside a instance below code will throw a error
        //int a = 20;
         void  MakeSound();

        void SleepSound();
    }
}
