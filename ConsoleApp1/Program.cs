using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Neeraj";
            //int charAge = 35;
            //char singleChar = 'c';
            //double somenum = 3.55544;
            //Console.WriteLine("Name: "+name + "\nAge: "+charAge + "\nSingle Character: "+singleChar+"\nDouble number: "+somenum);
            //Console.ReadKey();

            //working with strings

            string name = "John walter";

            //some of the escape sequence

            //Console.WriteLine("Adding a single quote"+"\'");
            //Console.WriteLine("Double quote" + "\"");
            //Console.WriteLine("back slash" + "\\");
            //Console.WriteLine("Null " + "\0");
            //Console.WriteLine("New line " + "\n");
            //Console.WriteLine("Horizonta tab" + "\t");


            //A formatted string

            //string date = String.Format("Today's date is {0}",DateTime.Now);


            //String[] splittedDate = date.Split(' ');

            //for (int i = 0; i < splittedDate.Length; i++)
            //{
            //    Console.Write(splittedDate[i]);
            //    Console.WriteLine();

            //}

            //below line will print from index 0 to 4
            //Console.WriteLine(name.Substring(0,5));

            //below code returns zero if the comparision is successfull and returns 1 if not
            //Console.WriteLine(name.CompareTo("John walter"));

            //name = name.Replace(name,"John");
            //Console.WriteLine(name);

            //string[] anotherNames = { "John","Micheal","Walter"};
            //Console.WriteLine(string.Join("?",anotherNames)); //output---> John? Micheal?Walter

            //checks whether the string ends with and return a boolean
            //Console.WriteLine(name.EndsWith("r"));    

            //Remove() removes a character
            //ToUpper()
            //ToLower()
            //PadLeft()  --> add some padding to the left
            //PadRight()  --> add padding to the right

            //StartsWith() ---> checks if the strig starts with the given string

            /*Console.WriteLine(name.StartsWith("Nee"));*/ //returns false

            //converts the string into array
            //Console.WriteLine(name.ToCharArray()[0]);

            //returns the index if found...if not will return -1
            //Console.WriteLine(name.LastIndexOf("a"));

            //Working with numbers

            //Console.WriteLine(5%2);
            //Console.WriteLine(5*2);
            //Console.WriteLine(53-3);
            //prints out the minimum
            //Console.WriteLine(Math.Min(100,1));


            //for rounding numbers
            //Console.WriteLine(Math.Round(123.78)); //output 124

            //Getting user input in C#



            //Console.ReadKey(); //this line basically waits for a user to pass something

            //Console.Write("Enter you name: ");
            //string enteredName = Console.ReadLine();


            ////as the user input is always in string the below line of code Convert.ToInt32() with conver the string into a int
            //int enterYouAge = Convert.ToInt32( Console.ReadLine());
            //Console.Write("Hi, " + enteredName+" You are "+enterYouAge+" years old!!");


            //arrays ---> collections of values

            //methods

            //return



            //Console.WriteLine(returnName());

            //if (true)
            //{
            //    Console.WriteLine(true);
            //}

            //if statement without a curly braces



            Console.ReadKey();





        }

        //static string returnName() {
        //    return "Neeraj";
        //}
    }
}
