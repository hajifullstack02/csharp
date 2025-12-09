using System;
using System.Collections.Generic;


namespace Csharp_Dec_Step4
{
    class HashsetExample
    {
        static void Main()
        {
            HashSet<string> userNames = new HashSet<string>();

            // Adding items to the HashSet
            userNames.Add("Alice");
            userNames.Add("Bob");
            userNames.Add("Charlie");


            userNames.Add("Alice");


            // Checking if an item exists in the HashSet
            Console.WriteLine("Is 'Alice' in the HashSet? " + userNames.Contains("Alice"));


            foreach (string name in userNames)
            {
                Console.WriteLine(name);
            }


            userNames.Remove("Bob");

            // Checking if an item exists in the HashSet
            Console.WriteLine("Is 'Alice' in the HashSet? " + userNames.Contains("Bob"));

            Console.WriteLine();

        }
    }
}