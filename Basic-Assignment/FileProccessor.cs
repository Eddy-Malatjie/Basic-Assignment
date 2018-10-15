using System;
using System.Text;
using System.IO;

namespace Basic_Assignment
{
    class FileProccessor
    {
        private string _fileName;
        private int _ID;
        public FileProccessor(string fileName, int id)
        {
            _ID = id;
            _fileName = fileName;
        }

        public void Process()
        {
            string fileType, fileText = "";
            string outputFileName = "";
            string SqlInsert = "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status)";
            int pos;

            ReadFile RF = new ReadFile(_ID);
            WriteFile WF = new WriteFile();

            pos = _fileName.IndexOf("_") + 1;
            fileType = _fileName.Substring(pos, 1);

            if (Int32.Parse(fileType) == 1)
            {
                pos = _fileName.IndexOf(".") + 1;
                outputFileName = _fileName.Substring(0, pos) + "sql";
                fileText = RF.ReadTypeOne(_fileName, SqlInsert);
                WF.WriteToFile(fileText, outputFileName);

            }

            if (Int32.Parse(fileType) == 2)
            {
                pos = _fileName.IndexOf(".") + 1;
                outputFileName = _fileName.Substring(0, pos) + "sql";
                fileText = RF.ReadTypeTwo(_fileName, SqlInsert);
                WF.WriteToFile(fileText, outputFileName);

            }
            if (Int32.Parse(fileType) == 3)
            {

                pos = _fileName.IndexOf(".") + 1;
                outputFileName = _fileName.Substring(0, pos) + "sql";
                fileText = RF.ReadTypeThree(_fileName, SqlInsert);
                WF.WriteToFile(fileText, outputFileName);


            }

        }
     
    }

}