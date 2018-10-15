using System;
using System.IO;

namespace Basic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            int idNum = Int32.Parse(args[1]);


            if (File.Exists(fileName))
            {

                FileProccessor FR = new FileProccessor(fileName, idNum);
                FR.Process();
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }

            Console.ReadKey();
        }
    }
}
