using System;
class StringExample
{
    static void Main()
    {
        string coursename = "Csharp";

        Console.WriteLine(coursename);

        string uCourseName = "\"Csharp\"";
        Console.WriteLine(uCourseName);

        string lStatus = "one. \n two. \n three";
        Console.WriteLine(lStatus);

        string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";
        Console.WriteLine(myProjectPath);

        string myProjectPath1 = @"D:\Csharp_Nov\MyFirstConsoleApp";
        Console.WriteLine(myProjectPath1);

        string sName = "Mery";
        int age = 15;

        //string interpolaiton technique
        string studentDetails = $"Student name : {sName} , Student age : {age} ";
        Console.WriteLine(studentDetails);

        //${ }


    }
}
