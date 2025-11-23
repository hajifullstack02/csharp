using System;
class Program
    {
        static void Main()
        {
        printFirstCheckpoint();
        }
       static void printFirstCheckpoint()
    {
        Console.WriteLine("*****checkpoint one*****");
        string studentname = "somu";
        int studentage = 20;
        decimal courseFee = 29999.9934M;
        Console.WriteLine($"the student is {studentname} and age is {studentage} and coursefee is {courseFee}");
        Console.WriteLine("get the location");
       String getStudentLocation= Console.ReadLine();
        Console.WriteLine($"student location is {getStudentLocation}");
    }
    }

