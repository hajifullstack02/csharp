using System;
class Methods_ReturnTypes
{

    //Declare - create - mention

    //upto your choice do you want to use or not anywhere in your app?

    //Calling method from Main
    static void Main()
    {
        string testmethodResult = TestMethod1();
        Console.WriteLine(testmethodResult);

        decimal PriceResult = getPrice();
        Console.WriteLine(PriceResult);

        bool isEqualResult = isEqual();
        Console.WriteLine(isEqualResult);


        string[] studentsResult = getStudentNames();
        foreach (string student in studentsResult)
        {
            Console.WriteLine(student);
        }

    }

    // mehtod with string return type
    static string TestMethod1()
    {
        return "Fired";
    }
    static decimal getPrice()
    {
        return 120.98m;
    }
    static bool isEqual()
    {
        int first = 10;
        int second = 20;
        if (first == second)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static string[] getStudentNames()
    {
        string[] students = new string[] { "John", "ram", "sam" };
        return students;
    }

    static void CheckFewMethods()
    {
        TestMethod1();
        getPrice();
    }

}
