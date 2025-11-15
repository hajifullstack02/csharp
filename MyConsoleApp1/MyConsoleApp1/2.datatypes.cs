using System;
class Datatypes
{
    static void Main()
    {

        Console.WriteLine("Hello" + "world"); //hello world;

        Console.WriteLine("Hello" + 1234);    //hello 1234;


        //Console.WriteLine("byte maxvalue" + byte.MaxValue);
        //string interploation ---    ${ }
        Console.WriteLine($"byte maxvalue : {byte.MaxValue}");

        // Console.WriteLine("byte minvalue" + byte.MinValue);
        Console.WriteLine($"byte minvalue :  {byte.MinValue}");



        //bool : true or false ----> html element one element --->
        bool isChecked = true;
        Console.WriteLine(isChecked);   // true;


        bool isChecked1 = false;
        Console.WriteLine(isChecked1);   // false;

        // X element --> from that element i am receing the ouput ---> output is the boolean . so then 
        // what could be element ???  checkbox


        char charValue = 'a';
        Console.WriteLine(charValue);

        char spaceValue = ' ';
        char numberVlae = '*';
        Console.WriteLine(numberVlae);
        Console.WriteLine(spaceValue);


        string status = "Hello , world";  //collection of charcters..
        Console.WriteLine(status);



    }
}