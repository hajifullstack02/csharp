
using System;
class Methods
{

    // collection of statements.
    // executes as a single unit.

    //Entry point Main

    // i can call method inside of the Main Method
    static void Main()
    {
        AllMethods();
    }


    //Void - Non-return type
    static void TestMethod1()
    {
        Console.WriteLine("Fired !!");
    }

    //Void - Non-return type
    static void TestMethod2()
    {
        Console.WriteLine("One more time Fired !!");
    }


    //Void - Non-return type
    static void AllMethods()
    {
        TestMethod1();
        TestMethod2();
    }

}