
using System;

class StringMoreConcepts
{
    static void Main()
    {

        string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";

        //Members ---> Family   f , m , b , s , gf , gm
        //myProjectPath.Length

        string name1 = "john";   //4
        int lengt = name1.Length;             //4
        Console.WriteLine(lengt); //4

        string name2 = "john";
        string uName2 = name2.ToUpper(); // "JOHN"  // ?? what could be return data type ??
        Console.WriteLine(uName2);

        string name3 = "JohN";
        string uName3 = name3.ToLower(); // "john"  // ?? what could be return data type ??
        Console.WriteLine(uName3);


        string name4 = "   John   ";
        string uName4 = name4.Trim();   // "John"


        string name5 = "****John****";
        string uName5 = name5.Trim('*');  // Calling Trim() method by passing the * argument.
        Console.WriteLine($"uName5 {uName5}");



        string name6 = "****John****";
        string uName6 = name6.TrimStart('*');  // Calling Trim() method by passing the * argument.
        Console.WriteLine($"uName6 {uName6}");



        string name7 = "****John****";
        string uName7 = name7.TrimEnd('*');  // Calling Trim() method by passing the * argument.
        Console.WriteLine($"uName7 {uName7}");


        //add spaces 10 spaces before john
        string name8 = "John";  //"         John";
        string pName8 = name8.PadLeft(10);
        Console.WriteLine($"name8 is {pName8}");


        //add spaces some * before john
        string name9 = "John";  //"***John";
        string pName9 = name9.PadLeft(10, '*');
        Console.WriteLine($"name9 is {pName9}");


        //add spaces some * before john
        string name10 = "John";  //"***John";
        string pName10 = name10.PadRight(10, '*');
        Console.WriteLine($"name9 is {pName10}");


        //Equal
        string password = "admin123";
        string confirmpassword = "admin123";


        //web page //reg pas and confrm  enable the button.
        bool isEquals = password.Equals(confirmpassword);
        Console.WriteLine(isEquals);


        string sentece = "The Quick brown fox jumps over the lazy dog";
        string sentence1 = sentece.Substring(4); //Quick brown fox jumps over the lazy dog
        Console.WriteLine(sentence1);


        //string sentece = "The Quick brown fox jumps over the lazy dog";
        string sentence2 = sentece.Substring(4, 10); //Quick brown fox jumps over the lazy dog
        Console.WriteLine(sentence2);


        string sentence3 = sentece.Replace("brown", "red");
        Console.WriteLine(sentence3);

        //format

        int quanitty = 12;  // 10pens
        double price = 9.99; //pricevalue

        double finalOuput = quanitty * price;


        //Client message : "Hey User ... You are having the 10 pens and total cost is 11.56 * quantity";

        string message = string.Format("Hey User ... You are having the {0} pens and total cost is {1}",
                                                      quanitty, finalOuput);

        Console.WriteLine(message);




    }
}