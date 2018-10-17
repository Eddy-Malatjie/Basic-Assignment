# Basic-Assignment

This is a software that converts txt file contents into Sql format

Getting Started

#### Prerequisites
You need to to have the following installed on your machine

* .NET Framework - avilable here:https://www.microsoft.com/net/download/dotnet-framework-runtime
* .NET Core SDK - available here:https://www.microsoft.com/net/download/thank-you/dotnet-sdk-2.1.403-windows-x64-installer
* .NET Core CLI - is installed with .NET Core SDK

#### Installing
* If you need help installation and to the enviroment running - https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x

#### Running the software

* Clone or Download the repository to a folder on your local machine-https://github.com/Eddy-Malatjie/Basic-Assignment.git

* You first need to create an executable which can be achieved by:
#### Build and Run the application

* Open the command prompt
* Navigate to "./BasicAssignment/" directory in the folder containing the project 
* Run the command [dotnet"] to test whether whether the .Net Core SDK installed properlly
* To build the application run [dotnet build] .

##### To run the unit tests

* Navigate to "./BasicAssignment/Assigment.tests/" 
* Run the command [dotnet test] to run all the unit test

##### To run the program

* Navigate to "./BasicAssignment/Assigment/" 
* Run [set path="C:\Windows\Microsoft.NET\Framework\v4.0.30319"]
* Run the command "[csc /out:MainProgram.exe \*.cs]" 
* The command above creates an executable(.exe) file which will be used to run the program
* Then to acquire the desired results run [MainProgram.exe "\filepath\<file_name>.txt" 400]
* Go the the file path of the input file to find the .sql file
