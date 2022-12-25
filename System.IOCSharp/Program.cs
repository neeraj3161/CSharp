using System;
using System.IO;

namespace System.IOCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using the File method
            //Directory
            //Path
            //@ symbole allow us to use / without using it as // as we norally do
            //$"{}" this is one of the form of formatted strig which can include valriable with curley brackets
            var path = @"D:\comp";

            //string[] directorys = Directory.GetDirectories(path,"*and*.*",SearchOption.AllDirectories); ---> we added a filter in the file name which should include and let's do the same for extention
            //string[] directorys = Directory.GetDirectories(path, "*.pdf", SearchOption.AllDirectories); ---> directory cannot have a extention

            string[] directorys = Directory.GetFiles(path, "*.c", SearchOption.AllDirectories);
            foreach (string directory in directorys)
            {
                Console.WriteLine(Path.GetFileName(directory));
                
            }

            Console.ReadLine();
        }
    }
}
