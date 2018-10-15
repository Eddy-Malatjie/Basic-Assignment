using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Assignment
{
    class ReadFile
    {
        private int ID;
       public ReadFile(int id)
        {
            ID = id;
            
        }

        public string ReadTypeOne(string fileName, string sqlInsert)
        {
            string firstName = "", lastName = "", gender = "", DOB = "", maritalStatus = "", Result = "";
            int pos;
            string line;
            string SqlString = "";


            try
            {
                using (StreamReader SR = new StreamReader(fileName))
                {

                    while ((line = SR.ReadLine()) != null)
                    {
                        pos = line.IndexOf(" ");
                        firstName = line.Substring(0, pos);
                        line = line.Remove(0, pos + 1);

                        pos = line.IndexOf(",");
                        lastName = line.Substring(0, pos);
                        line = line.Remove(0, pos + 1);

                        pos = line.IndexOf(",");
                        gender = line.Substring(1, pos - 1);
                        line = line.Remove(0, pos + 1);

                        pos = line.IndexOf(",");
                        DOB = line.Substring(0, pos);
                        line = line.Remove(0, pos + 1);

                        if (line == " Y")
                        {
                            maritalStatus = true.ToString();
                        }
                        else
                        {
                            maritalStatus = false.ToString();
                        }


                        Result = " values(" + ID + ",'" + firstName + "','" + lastName + "','" + gender + "','" + DOB + "'," + maritalStatus + ")";
                        SqlString = SqlString + sqlInsert + Result + Environment.NewLine;
                        ID++;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SqlString;
        }
        public string ReadTypeTwo(string fileName, string sqlInsert)
        {
            string firstName = "", lastName = "", gender = "", DOB = "", maritalStatus = "", Result = "";
            string SqlString = "";
            int pos;
            string line;


            try
            {
                using (StreamReader SR = new StreamReader(fileName))
                {

                    while ((line = SR.ReadLine()) != null)
                    {

                        for (int i = 0; i < line.Length; i++)
                        {
                            line = line.Replace('"', ' ');

                        }



                        pos = line.IndexOf("|");
                        firstName = line.Substring(0, pos - 1);
                        firstName = char.ToUpper((char)firstName[1]).ToString() + firstName.Substring(2).ToLower();
                        line = line.Remove(0, pos + 1);

                        pos = line.IndexOf("|");
                        lastName = line.Substring(0, pos - 1);
                        lastName = char.ToUpper((char)lastName[1]).ToString() + lastName.Substring(2).ToLower();
                        line = line.Remove(0, pos + 1);

                        pos = line.IndexOf("|");
                        DOB = DateTime.Parse(line.Substring(0, pos - 1)).ToString("dd/MM/yyyy");
                        line = line.Remove(0, pos + 1);

                        pos = line.IndexOf("|");

                        if (line.Substring(1, pos - 2) == "Married")
                        {
                            maritalStatus = true.ToString();
                        }
                        else
                        {
                            maritalStatus = false.ToString();
                        }
                        line = line.Remove(0, pos + 1);

                        pos = line.Length - 2;

                        if (line.Substring(1, pos) == "Male")
                        {
                            gender = "M";
                        }
                        else
                        {
                            gender = "F";
                        }


                        Result = " values(" + ID + ",'" + firstName + "','" + lastName + "','" + gender + "','" + DOB + "'," + maritalStatus + ")";
                        SqlString = SqlString + sqlInsert + Result + Environment.NewLine;
                        ID++;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return SqlString;
        }
        public string ReadTypeThree(string fileName, string sqlInsert)
        {
            string firstName = "", lastName = "", gender = "", DOB = "", maritalStatus = "", Result = "";
            string SqlString = "";
            int pos;
            string line;

            try
            {
                using (StreamReader SR = new StreamReader(fileName))
                {

                    while ((line = SR.ReadLine()) != null)
                    {

                        for (int i = 0; i < line.Length; i++)
                        {
                            line = line.Replace('"', ' ');

                        }


                        if (line != "#")
                        {
                            pos = line.IndexOf(":");

                            if (line.Substring(0, pos) == "name")
                            {

                                firstName = line.Substring(pos + 2);
                                firstName = char.ToUpper((char)firstName[0]).ToString() + firstName.Substring(1);


                            }
                            if (line.Substring(0, pos) == "surname")
                            {

                                lastName = line.Substring(pos + 2);
                                lastName = char.ToUpper((char)lastName[0]).ToString() + lastName.Substring(1);

                            }
                            if (line.Substring(0, pos) == "dob")
                            {

                                DOB = DateTime.Parse(line.Substring(pos + 2)).ToString("dd/MM/yyyy");
                            }

                            if (line.Substring(0, pos) == "married")
                            {
                                if (line.Substring(pos + 2) == "yes")
                                {
                                    maritalStatus = true.ToString();
                                }
                                else
                                {
                                    maritalStatus = false.ToString();
                                }
                            }
                            if (line.Substring(0, pos) == "gender")
                            {
                                if (line.Substring(pos + 2) == "male")
                                {
                                    gender = "M";
                                }
                                else
                                {
                                    gender = "F";
                                }
                            }
                        }
                        else
                        {

                            if (firstName != "" && lastName != "" && gender != "" && DOB != "" && maritalStatus != "")
                            {
                                Result = " values(" + ID + ",'" + firstName + "','" + lastName + "','" + gender + "','" + DOB + "'," + maritalStatus + ")";
                                SqlString = SqlString + sqlInsert + Result + Environment.NewLine;
                                ID++;
                            }

                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return SqlString;
        }
    }
}
