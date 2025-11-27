using System;
using System.Xml.Linq;


namespace Family
{
    class Father
    {
        public string Name { get; set; }

        public Father()
        {
            Name = "Robert";
            Console.WriteLine($"name paramter is is {Name}");
        }

        public Father(string myKidName)
        {
            Name = "Robert";
            Console.WriteLine($"name paramter is is {Name} my kidName is {myKidName}");
        }
    }

    class Mother
    {

    }

    class Child : Father   // , Mother 
    {
        public Child()
        {
            Console.WriteLine($"From Child Class and myfather name is {Name}");
        }
        public Child(string childName) : base(childName)  //base keyword means base = Father
        {
            Console.WriteLine($"From Child Class and myfather name {Name} and My name is {childName}");
            Console.WriteLine(this);   // here this means Childclass not Parentclass
        }
    }

    class Program
    {
        static void Main()
        {
            Child child = new Child("Andrew");
            //Note first here parent of members will be treated first then child
        }
    }
}