using System;
using System.Collections;


namespace Csharp_Dec_Step4
{
    class HashtableExample
    {
        static void Main()
        {

            //not typesafe

            Hashtable studentDetails = new Hashtable();
            studentDetails.Add("Name", "Alice");  //dictentry
            studentDetails.Add("Age", 25);
            studentDetails.Add("Location", "New York");
            studentDetails.Add("IsStudent", true);  //a


            //Fetch the value 


            //object ---> object into respective type like below called boxing 

            //string  ---> object called unboxing...

            string name = (string)studentDetails["Name"];    //As a madan seeing the code and saying the value i.e. Alice

            //step 1
            //var name = studentDetails["Name"];

            // Console.WriteLine(name);  //fetch

            //foreach(DictionaryEntry item in studentDetails)
            //{
            //    //Console.WriteLine(item.Value);
            //    //  Console.WriteLine(item.Key);

            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}



            studentDetails.Remove("Name");  //r

            studentDetails["Age"] = 30;  //u




            //foreach (DictionaryEntry item in studentDetails)
            //{
            //    //Console.WriteLine(item.Value);
            //    //  Console.WriteLine(item.Key);

            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}



            studentDetails.Clear();  //erase
            foreach (DictionaryEntry item in studentDetails)
            {
                //Console.WriteLine(item.Value);
                //  Console.WriteLine(item.Key);

                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine();

        }

    }
}