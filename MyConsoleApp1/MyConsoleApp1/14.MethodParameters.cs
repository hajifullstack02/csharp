using System;
using System.Dynamic;

class Methods_parameters
{
    static void Main()
    {
        PrintID(1244);
        string empName = getEmpNameByID(1);
        Console.WriteLine(empName);
    }


    static void PrintID(int ID)
    {
        Console.WriteLine(ID);
    }

    static string getEmpNameByID(int ID)
    {
        if (ID == 1)
        {
            return "John";
        }
        else if (ID == 2)
        {
            return "ram";
        }
        else if (ID == 3)
        {
            return "Sam";
        }
        else
        {
            return "NO NAme";
        }
    }



    //var you cannot pass as parameter
    static string getName(dynamic ID)
    {
        return "JOhn";
    }


    //var you cannot pass as parameter
    static dynamic getName1()
    {
        return "JOhn";
    }


    static int getResult(string param1, int param2, string param3)
    {
        Console.WriteLine(param1);
        Console.WriteLine(param2);
        return 108;
    }





}
