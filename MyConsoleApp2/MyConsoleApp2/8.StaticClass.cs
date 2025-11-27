using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClasses_Step2
{


    //1. Static class in C# is a class that we cannot be Instatiated and it can only contain static members.

    //2. static members calls by using className

    //3. All members of the static class related to class itself only.

    //4. we cannt use this keyword in static class. instead of you can use classname itself only directly.

    static class StaticClassDemo
    {
        static int age = 20;

        static double salary = 12345.67d;

        static void PrintNumber()
        {
            Console.WriteLine(StaticClassDemo.age);
        }

        static string[] getNames()
        {
            return new string[] { "John", "Ram" };
        }

        static void Main()
        {
            //StaticClassDemo demo1 = new StaticClassDemo();

            int customerAge = StaticClassDemo.age;
            Console.WriteLine($"customerage{customerAge}");


            string[] customerNames = StaticClassDemo.getNames();




        }

    }
}