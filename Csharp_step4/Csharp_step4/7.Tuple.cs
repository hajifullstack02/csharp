using System;


namespace Csharp_Dec_Step4
{
    class TupleExample
    {

        static (int id, string name, bool isActive) GetPerson1Details()
        {
            return (46, "John", true);
        }



        static void Main()
        {

            //Creating the valueTuple with named fields
            (int id, string name, bool isActive) person1 = (46, "John", true);


            var person1Details = GetPerson1Details();
            Console.WriteLine(person1Details.id); // 46


            //Access by variable name
            Console.WriteLine($" ID : {person1.id}, Name : {person1.name} , IsActive {person1.isActive}");


            Tuple<int, string, bool> person2 = new Tuple<int, string, bool>(47, "Robert", true);




















            int person2Age = person2.Item1;// 47;
            string person2Name = person2.Item2; // "Robert"
            bool person2isMarriedStatus = person2.Item3; // true


            Console.WriteLine($" ID : {person2Age}, Name : {person2Name} , IsActive {person2isMarriedStatus}");
            Console.WriteLine("Person3 type is ", person2.GetType());

            var person3 = new Tuple<int, string, bool>(48, "Mary", true);

            int person3Age = person3.Item1;// 47;
            string person3Name = person3.Item2; // "Robert"
            bool person3isMarriedStatus = person3.Item3; // true


            Console.WriteLine($" ID : {person3Age}, Name : {person3Name} , IsActive {person3isMarriedStatus}");
            Console.WriteLine("Person3 type is ", person3.GetType());




            //Gets the location latitude and longitude values.
            var location = (latitude: 12.9716, longitude: 77.5946);
            Console.WriteLine($"Latitude: {location.latitude}, Longitude: {location.longitude}");





        }


    }
}