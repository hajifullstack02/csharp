using System;
using System.Collections.Generic;


namespace Csharp_Dec_Step4
{
    class DictionaryExample
    {
        //Dictornary<Tkey,TValue>
        static void Main()
        {


            //pro-devel

            //average devel


            Dictionary<int, string> book = new Dictionary<int, string>();

            book.Add(1, "Chapter1");
            book.Add(2, "Chapter2");
            book.Add(3, "Chapter3");

            string chapterName = book[2];  //Chapter2

            //foreach (KeyValuePair<int,string> item in book)
            //{
            //    Console.WriteLine($"Key {item.Key} : Value  {item.Value}");
            //}

            foreach (var item in book)
            {
                Console.WriteLine($"Key {item.Key} : Value  {item.Value}");
            }


            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            // Adding items to the dictionary
            studentGrades.Add("Alice", 1);
            studentGrades.Add("Bob", 2);
            studentGrades.Add("Charlie", 1);


            //David


            //-------------------------|                    |
            //   Key       | value     |
            //-------------|-----------|
            //  Alice      | 1        |
            //  Bob        | 2        |
            //  Charlie    | 1        |
            //  Alice      | 10     --- inserting wrong value


            int bobGrade = studentGrades["Bob"];   //2


            bool isDavidAvailble = studentGrades.ContainsKey("David");


            Console.WriteLine("\nAll student grades:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }


            //--------update----
            studentGrades["Charlie"] = 3;
            Console.WriteLine("\nAll student grades:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }


            //--------update----
            bool isBobHasRemoved = studentGrades.Remove("Bob");
            Console.WriteLine("\nAll student grades:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }








        }
    }
}