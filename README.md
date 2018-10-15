# Basic-Assignment

This is a software that converts txt file contents into Sql format

Getting Started

#### Prerequisites
You need to to have the following installed on your machine

.NET Framework - avilable here:https://www.microsoft.com/net/download/dotnet-framework-runtime
.NET Core SDK - available here:https://www.microsoft.com/net/download/thank-you/dotnet-sdk-2.1.403-windows-x64-installer
.NET Core CLI - is installed with .NET Core SDK

#### Installing
If you need help installation and to the enviroment running - https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x

#### Running the software

Clone or Download the repository to your local machine-https://github.com/Eddy-Malatjie/Basic-Assignment.git

You first need to create an executable which can be achieved by:

Opening the command prompt

Insert the command - set path="pathToFramwork" - pathToframework = C:\Windows\Microsoft.NET\Framework\v4.0.30319

Navigate to the repository containing folder on your machine and into the directory "..\Basic-Assignment"

Enter the command -csc /out:Test.exe *.cs 

The command above creates an executable(.exe) "Test" will be the name

You will the use "Test.exe" to run the program

Then to acquire the desired results enter : Test.exe "\filepath\<file_name>.txt" 400

Go the the file path of the input file to find the .sql file
