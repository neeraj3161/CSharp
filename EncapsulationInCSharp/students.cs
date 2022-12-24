using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationInCSharp
{
    public class Students
    {
        private int numberOfStudents = 5000;

        //public int getNumberOfStudents { get { return numberOfStudents; } }

        //public int setNumberOfStudents { set { numberOfStudents = value>10?value:numberOfStudents; } }

        public int getSetNumberOfStudents { get { return numberOfStudents; } set { numberOfStudents = value > numberOfStudents ? value : numberOfStudents; } }

    }
}
