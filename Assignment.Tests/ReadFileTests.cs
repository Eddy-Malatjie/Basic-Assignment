using Xunit;
using Assignment;
using System;

namespace Assignment.Tests
{
    public class ReadFileTests
	{
        /*[Fact]
		public void Add_ShouldCalculate()
		{		
		
		//arrange
		 double expected ="" ;
		
		//act
		double actual = ReadFile;
		
		//Assert
		Assert.Equal(expected,actual);
		}*/


        [Fact]
        public void ReadTypeOne_ShouldReturnSqlFormat()
        {
            //arrange
            string expected = "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status) values(400,'Manmay','Mohanty','M',' 07/03/1983',True)"+Environment.NewLine+"insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status) values(401,'Marike','Fourie','F',' 30/11/2001',False)"+ Environment.NewLine;

            //act
            string actual = ReadFile.ReadTypeOne(@"C:\Users\Reverside\Desktop\customers_1.txt", "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status)", 400);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReadTypeTwo_ShouldReturnSqlFormat()
        {
            //arrange
            string expected = "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status) values(400,'Manmay','Mohanty','M','07/03/1983',True)" + Environment.NewLine + "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status) values(401,'Marike','Fourie','F','30/11/2001',False)" + Environment.NewLine;

            //act
            string actual = ReadFile.ReadTypeTwo(@"C:\Users\Reverside\Desktop\customers_2.txt", "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status)", 400);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReadTypeThree_ShouldReturnSqlFormat()
        {
            //arrange
            string expected = "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status) values(400,'Manmay','Mohanty','M','07/03/1983',True)" + Environment.NewLine + "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status) values(401,'Marike','Fourie','F','30/11/2001',False)" + Environment.NewLine;

            //act
            string actual = ReadFile.ReadTypeThree(@"C:\Users\Reverside\Desktop\customers_3.txt", "insert into customers(id, first_name, last_name, gender, date_of_birth, marital_status)", 400);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
