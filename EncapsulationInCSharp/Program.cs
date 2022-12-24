using System;

namespace EncapsulationInCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Students students = new Students();
            students.getSetNumberOfStudents = 23659;
            Console.Write(students.getSetNumberOfStudents);
            Console.ReadLine();
        }
    }
}
