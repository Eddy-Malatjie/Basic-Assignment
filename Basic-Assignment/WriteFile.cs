using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignment
{
    class WriteFile
    {
        public void WriteToFile(string textToWrite, string OutFileName)
        {

            try
            {

                if (File.Exists(OutFileName))
                {
                    File.Delete(OutFileName);
                }


                using (FileStream fs = File.Create(OutFileName))
                {

                    Byte[] fileContent = new UTF8Encoding(true).GetBytes(textToWrite);
                    fs.Write(fileContent, 0, fileContent.Length);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
