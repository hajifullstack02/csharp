using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClasses_Step2
{
    static class Logger
    {
        //Fields
        static string _logFile = "applicaiton1.txt";
        static string _logFileDesc = "You have logged in the App at mar-05-2025 at 1:00pm";

        //Properies
        static string LogFile { get; set; }

        //Constructor
        static Logger()
        {
            Logger.LogFile = _logFile;
        }

        static void LogMessage(string Level, string Message)
        {
            Console.WriteLine($"{DateTime.Now}  :- {Level} {Message}");
        }

        static void InfoMessage(string Message)
        {
            Logger.LogMessage("Info", Message);
        }

        static void WarningMessage(string Message)
        {
            Logger.LogMessage("Warn", Message);
        }

        static void ErrorMessage(string Message)
        {
            Logger.LogMessage("Error", Message);
        }

        static void Main()
        {
            Console.WriteLine($"Log file name field is {Logger._logFile}");

            Console.WriteLine($"Log file desc is {Logger._logFileDesc}");

            Console.WriteLine($"Log file name prop is {Logger.LogFile}");

            Logger.InfoMessage("Applicaiton started");

            Logger.WarningMessage("YOu have entered the wrong password . if you do again account will be block");

            Logger.ErrorMessage("Somehting is wrong .... Please cehck again");

            Logger.InfoMessage("Applicaiton Stopped");

        }




    }
}