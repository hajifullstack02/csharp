using System;
using System.Collections.Generic;

namespace FuncNamespace_Hospital
{
    class Program
    {
        static void Main()
        {
            // -----------------------------------------------------
            // 1. Func with NO INPUT and STRING return
            // -----------------------------------------------------
            Func<string> registerPatient = () =>
            {
                return "Patient registration completed successfully.";
            };

            string regMessage = registerPatient();
            Console.WriteLine(regMessage);



            // -----------------------------------------------------
            // 2. Func with ONE INPUT and STRING return
            // -----------------------------------------------------
            Func<string, string> assignDoctor = (string patientName) =>
            {
                return $"Doctor assigned to patient: {patientName}";
            };

            string doctorMessage = assignDoctor("Rahul");
            Console.WriteLine(doctorMessage);



            // -----------------------------------------------------
            // 3. Func with TWO INPUTS and STRING return
            // -----------------------------------------------------
            Func<int, string, string> startTreatment = (int patientID, string disease) =>
            {
                return $"Treatment started for PatientID: {patientID}, Disease: {disease}";
            };

            string treatmentMsg = startTreatment(101, "Fever");
            Console.WriteLine(treatmentMsg);



            // -----------------------------------------------------
            // 4. Func with TWO INPUTS and DECIMAL return
            // -----------------------------------------------------
            Func<int, string, decimal> calculateBill = (int patientID, string treatmentName) =>
            {
                // Some logic…
                return 2500.75m; // returning dummy bill amount
            };

            List<int> patientIDs = new List<int>() { 101, 102 };

            decimal bill1 = calculateBill(patientIDs[0], "General Checkup");
            Console.WriteLine($"Patient Bill 1: {bill1}");

            decimal bill2 = calculateBill(patientIDs[1], "X-Ray Scan");
            Console.WriteLine($"Patient Bill 2: {bill2}");
        }
    }
}
