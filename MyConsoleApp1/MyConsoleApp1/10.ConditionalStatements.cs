using System;
class ConditionalStatements
{
    static void Main()
    {
        // operatos
        // if statemnt else if statement  else statement 

        bool result = (10 < 20);

        string bankName = "SBI";

        if (bankName == "HDFC")
        {
            Console.WriteLine("MY Password is HajiHDFC!1234");
        }
        else if (bankName == "Axis")
        {
            Console.WriteLine("MY Password is HajiAxi!1234");
        }
        else if (bankName == "SBI")
        {
            Console.WriteLine("MY Password is HajiSBI!1234");
        }
        else
        {
            Console.WriteLine("You do't have permission to see the password");
        }





        //Switch ..... case




        //switch...case .. assume your swith board in your home...
        // executes the staments based on the case


        string switchKey = "";  // value

        switch (switchKey)
        {
            //we will prepare the cases
            case "MobilePhoneChargerKey":
                Console.WriteLine("You switched phone charger");
                break;
            case "tvKey":
                Console.WriteLine("You switched TV");
                break;
            case "fanKey":
                Console.WriteLine("You switched the fan");
                break;
            default:
                Console.WriteLine("No key is available");
                break;
        }




    }
}