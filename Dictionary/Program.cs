using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //creating the dictionary
            Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();


            //adding items to the dict
            //the key in the dictionary should be unique


            keyValuePairs.Add("Jonh", 22);
            keyValuePairs.Add("Mark", 22);
            keyValuePairs.Add("Albert", 22);
            keyValuePairs.Add("Mike", 22);
            keyValuePairs.Add("Micheal", 22);
            keyValuePairs.Add("Jayson", 22);
            keyValuePairs.Add("Adam", 22);
            keyValuePairs.Add("Marshal", 22);

            foreach (KeyValuePair<string, int> pair in keyValuePairs)
            {
                //formatted string
                Console.WriteLine("Value = {0}", pair.Value);
            }

            Console.ReadLine();

        }


    }
}
