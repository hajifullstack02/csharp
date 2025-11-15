using System;
class VarAndDynamic
{
    static void Main()
    {
        int number = 10;
        number = number + 1;
        //number = "Csharp";
        Console.WriteLine(number);   // 11
        //int number1 = "Csharp";


        string name = "Csharp";
        name = ".netCore fullstack development";
        //name = 10;
        Console.WriteLine(name);  // .netCore fullstack development


        double stockPriceOfsomeproduct = 12.987;  //
        stockPriceOfsomeproduct = 11.098;
        //stockPriceOfsomeproduct = false;
        Console.WriteLine(stockPriceOfsomeproduct);


        var someValue = 10;  // i want to assign value to the here 
        someValue = 20;
        //someValue     = "Csharp";

        Console.WriteLine(someValue);  // 20; int
        //Console.WriteLine(someValue.GetType());

        var someValue1 = "Csharp";
        Console.WriteLine(someValue1);
        //Console.WriteLine(someValue1.GetType());


        var someValue2 = false;
        Console.WriteLine(someValue2);
        //Console.WriteLine(someValue2.GetType());


        dynamic d_someValue = 10;  // i want to assign value to the here 
        d_someValue = 20;
        d_someValue = "Csharp";
        d_someValue = false;

        Console.WriteLine($"dynamic value : {d_someValue}");  // false
        Console.WriteLine(d_someValue.GetType());  //boolean

        dynamic d_someValue1 = "Csharp";
        Console.WriteLine(d_someValue1);
        //Console.WriteLine(someValue1.GetType());


        dynamic d_someValue2 = false;
        Console.WriteLine(d_someValue2);
        //Console.WriteLine(someValue2.GetType());

    }
}