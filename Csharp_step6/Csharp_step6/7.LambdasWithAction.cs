using System;

namespace LambdasWithActionDelegate_Hospital
{
    internal class Program
    {
        static void Main()
        {
            // ---------------------------------------------------------
            // 1. Action with NO parameters
            // ---------------------------------------------------------
            Action registerPatient = () =>
            {
                Console.WriteLine("Reception: Patient registration completed.");
            };

            registerPatient();



            // ---------------------------------------------------------
            // 2. Action with ONE parameter
            // ---------------------------------------------------------
            Action<string> assignDoctor = (string patientName) =>
            {
                Console.WriteLine($"System: Doctor assigned to patient {patientName}.");
            };

            assignDoctor("Rahul");



            // ---------------------------------------------------------
            // 3. Action with TWO parameters
            // ---------------------------------------------------------
            Action<string, string> startTreatment = (string patientName, string disease) =>
            {
                Console.WriteLine($"Doctor: Starting treatment for {patientName}. Disease: {disease}");
            };

            startTreatment("Rahul", "Fever");



            // ---------------------------------------------------------
            // 4. Action with THREE parameters
            // ---------------------------------------------------------
            Action<string, string, decimal> generateBill =
                (string patientName, string treatmentType, decimal billAmount) =>
                {
                    Console.WriteLine(
                        $"Billing: Patient {patientName}, Treatment: {treatmentType}, Bill Amount: ₹{billAmount}"
                    );
                };

            generateBill("Rahul", "X-Ray", 1500.75m);



            // 16 parameters also possible (Action supports up to 16 inputs)
        }
    }
}
