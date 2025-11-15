using System;
class Arrays
{
    static void Main()
    {
        // [10 , 20 , 30]

        int[] numbersGroup = new int[2];  //numbersGroup accepts 2 values;
        numbersGroup[0] = 11;
        numbersGroup[1] = 21;

        Console.WriteLine(numbersGroup[0]);  // 11
        Console.WriteLine(numbersGroup[1]);  // 21

        //numbersGroup[2] = 32;   //No Complie time error.
        //Console.WriteLine(numbersGroup[2]);


        //string length , array length

        int[] numbersGroup1 = new int[] { 101, 201, 301, 401 };
        Console.WriteLine(numbersGroup1[numbersGroup1.Length - 1]);  // improvement 


        numbersGroup1[2] = 300;
        Console.WriteLine(numbersGroup1[2]);


        // student1 : hey print each and every value..

        //Console.WriteLine(numbersGroup1[0]);   // 101
        //Console.WriteLine(numbersGroup1[1]);   // 201
        //Console.WriteLine(numbersGroup1[2]);   // 300
        //Console.WriteLine(numbersGroup1[3]);   // 401


        //foreach (int number in numbersGroup1) {  
        //    Console.WriteLine(number);
        //}


        foreach (var number in numbersGroup1)
        {
            Console.WriteLine(number);
        }



    }
}