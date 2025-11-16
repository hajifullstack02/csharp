using System;
class LoopingMecanisam
{
    static void Main()
    {
        //while , do while , for , for each

        // while is also iexample of looping meachinam

        // based on the your requirment this block will be repeated(how many times)

        //while

        //int age = 10;
        //if (true)
        //{
        //    Console.WriteLine("Excuted");
        //}
        //Console.WriteLine("Hello world");

        int count = 0;
        while (count < 2)
        {
            Console.WriteLine("Excuted");
            count = count + 1;
        }
        // Console.WriteLine("Hello world1234");



        int result = 0;
        do
        {
            Console.WriteLine("Do....Excuted");
            result = result + 1;
        } while (result < 5);


        //
        string[] studentsList = new string[] { "john", "ram", "sam" };
        foreach (string student in studentsList)
        {
            //students names length should be 3 ;;
            //Console.WriteLine(student);

            //Q) print only student whose name length is 3
            if (student.Length == 3)
            {
                Console.WriteLine(student);
            }


        }




    }
}