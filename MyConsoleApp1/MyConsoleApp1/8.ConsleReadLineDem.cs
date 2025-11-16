using System;
class ConsleReadLineDem
{
    static void Main()
    {
        Console.WriteLine("Please enter your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"You have entered the vlaue is {name}");


        Console.WriteLine("Enter your password ?");
        string password = Console.ReadLine(); ;

        Console.WriteLine("Enter your Confirm password ?");
        string confirmpassword = Console.ReadLine();

        bool isEqual = password.Equals(confirmpassword);
        Console.WriteLine($"your password and confirm password is {isEqual}");


        string age = "20";
        int cage = int.Parse(age);   // Here 20 will become int


        Console.WriteLine("Your location PInCode");
        int pincode = int.Parse(Console.ReadLine());   // 560034 //int 
        Console.WriteLine(pincode);

        Console.WriteLine("Your Gender");
        char bGender = char.Parse(Console.ReadLine());   // 560034 //int 
        Console.WriteLine(bGender);


        string allData = string.Format("All the values Gender {0} Location {1}", bGender, pincode);
        Console.WriteLine(allData);





        //Input value -- caputre by using readline... compiler reading your value...


        //Generally input value type accepts the string , not bool , char , decimal , dounble , not even int



        //< , > , == , <= , >= , !


    }
}