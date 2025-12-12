using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasWithPredicateDelegate
{
    internal class Program
    {
        // Custom delegate that returns bool (checking availability)
        public delegate bool AvailabilityCheck(string item);

        static void Main()
        {
            //------------------------------------------------------------
            // 1. Predicate Example → Checking if patient is a "Critical" case
            //------------------------------------------------------------
            Predicate<string> isCriticalPatient = (string patientStatus) =>
            {
                return patientStatus == "Critical";
            };

            bool p1 = isCriticalPatient("Critical");   // true
            bool p2 = isCriticalPatient("Stable");     // false

            Console.WriteLine($"Patient 1 Critical? {p1}");
            Console.WriteLine($"Patient 2 Critical? {p2}");


            //------------------------------------------------------------
            // 2. Hospital Data (Patients List)
            //------------------------------------------------------------
            List<string> patients = new List<string>
            {
                "Ravi", "Madhan", "Joseph", "Dinesh"
            };


            //------------------------------------------------------------
            // 3. Predicate Example → Check if patient exists
            //------------------------------------------------------------
            Predicate<string> isPatientAvailable = (string patientName) =>
            {
                foreach (var patient in patients)
                {
                    if (patient == patientName)
                    {
                        return true;
                    }
                }
                return false;
            };

            Console.WriteLine($"Is Ravi available? {isPatientAvailable("Ravi")}");
            Console.WriteLine($"Is Karthik available? {isPatientAvailable("Karthik")}");


            //------------------------------------------------------------
            // 4. Custom Delegate Example (OrderAvailability → AvailabilityCheck)
            //    Checking if doctor is available in hospital
            //------------------------------------------------------------
            List<string> doctors = new List<string>
            {
                "Dr. John", "Dr. Priya", "Dr. Kumar"
            };

            AvailabilityCheck isDoctorAvailable = (string doctorName) =>
            {
                foreach (var doc in doctors)
                {
                    if (doc == doctorName)
                    {
                        return true;
                    }
                }
                return false;
            };

            Console.WriteLine($"Is Dr. John available? {isDoctorAvailable("Dr. John")}");
            Console.WriteLine($"Is Dr. Ram available? {isDoctorAvailable("Dr. Ram")}");


            //------------------------------------------------------------
            // 5. Another Predicate Example → Checking Available Treatments
            //------------------------------------------------------------
            List<string> treatments = new List<string>
            {
                "X-Ray", "MRI", "Blood Test", "ECG"
            };

            Predicate<string> isTreatmentAvailable = (string treatmentName) =>
            {
                return treatments.Contains(treatmentName);
            };

            Console.WriteLine($"Is MRI available? {isTreatmentAvailable("MRI")}");
            Console.WriteLine($"Is Surgery available? {isTreatmentAvailable("Surgery")}");
        }
    }
}
