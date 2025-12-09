using System;
using System.Collections.Generic;


namespace Csharp_Dec_Step4
{

    //List<T>
    class ListExample
    {
        static void Main()
        {
            // i want to prepare the list of values(ints)


            //you have to maintain same data. here ints
            //Its also dynamic type.

            //List<int> numbers = new List<int>();
            List<int> numbers = new List<int>() { 10, 20, 30 };

            //add
            numbers.Add(40);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(60);
            numbers.Add(60);   //int --> decimal --->

            Console.WriteLine("List Elements:");

            foreach (int num in numbers)
            {
                //Print each value..
                Console.WriteLine(num);
            }




            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("David");


            Console.WriteLine("List of Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            List<decimal> money = new List<decimal>();

            money.Add(100.99M);  //0
            money.Add(200.99M);  //1
            money.Add(300.99M);  //2
            money.Add(10);       // decimal--->int


            //decimal > int

            //money.Add("afasdfasdfa");



            //Insert a value at specific index
            money.Insert(1, 999.99M);

            //[100.99, 999.99, 200.99, 300.99]

            Console.WriteLine($"{money.Count} money");


            //remove
            money.RemoveAt(2);


            Console.WriteLine($"{money}");


            //update
            money[0] = 1000.99M;


            //checking the value is avaibale or not.


            bool isExists = money.Contains(999.99M);


            Console.WriteLine();




        }
    }
}