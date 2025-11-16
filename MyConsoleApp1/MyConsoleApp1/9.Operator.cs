using System;

class ArthamaticOperators
{
    //Undestand the behaviour of the operator...

    static void Main()
    {
        //Arthamatic opertos   + , - , * , / 9:03
        int result = 10 + 20;  // 30 numeric
        Console.WriteLine(result); // 30

        int result1 = 20 - 10;  // 30 numeric
        Console.WriteLine(result1); // 10

        // == , != , < , > , <= , >=  // true or false 
        bool isEqual = 10 == 10;
        Console.WriteLine(isEqual); // true , 10 , "Haji"

        bool isEqual1 = 10 == 20;
        Console.WriteLine(isEqual1); // false , 10 , "Haji"

        bool isEqual2 = 10 < 20;
        Console.WriteLine(isEqual2); // false , 10 , "Haji"

        bool isEqual3 = 10 > 20;
        Console.WriteLine(isEqual3); // false , 10 , "Haji"

        bool isEqual4 = (10 >= 20);
        Console.WriteLine(isEqual4); // false , 10 , "Haji"

        bool isEqual5 = (10 <= 20);
        Console.WriteLine(isEqual5); // false , 10 , "Haji"


        // (3+4) < 6

        //&& , || , !

        //T t - t  , t f - f , f t - f , f  f - f


        Console.WriteLine("-----------------AND--------------");

        bool isResult = (10 == 10) && (20 == 20);
        Console.WriteLine(isResult);

        bool isResult1 = (10 == 10) && (30 == 20);
        Console.WriteLine(isResult1);

        bool isResult2 = (20 == 10) && (20 == 20);
        Console.WriteLine(isResult2);

        bool isResult3 = (20 == 10) && (10 == 20);
        Console.WriteLine(isResult3);




        //T t - t  , t f - t , f t - t , f  f - f


        Console.WriteLine("----------------OR----------------");

        bool isResult4 = (10 == 10) || (20 == 20);
        Console.WriteLine(isResult4);

        bool isResult5 = (10 == 10) || (30 == 20);
        Console.WriteLine(isResult5);

        bool isResult6 = (20 == 10) || (20 == 20);
        Console.WriteLine(isResult6);

        bool isResult7 = (20 == 10) || (10 == 20);
        Console.WriteLine(isResult7);


        Console.WriteLine("----------------NOT  !----------------");

        bool isResult8 = !(10 == 10);  //false
        Console.WriteLine(isResult8);

        bool isResult9 = !(20 == 10);  //true
        Console.WriteLine(isResult9);


        // Ex : compare and Logical we will use in if else blocks


    }
}