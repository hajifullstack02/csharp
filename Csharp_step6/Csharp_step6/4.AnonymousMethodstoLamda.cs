using System;

namespace LambdaMethods_Hospital
{
    // Define a delegate for hospital tasks
    delegate void HospitalTask(string details);

    class Program
    {
        static void Main()
        {
            // Lambda for patient registration
            HospitalTask registerPatient = (string patientName) =>
            {
                Console.WriteLine("Reception: Registering patient - " + patientName);
            };

            // Lambda for assigning doctor
            HospitalTask assignDoctor = (string patientName) =>
            {
                Console.WriteLine("System: Assigning doctor to " + patientName);
            };

            // Lambda for starting treatment
            HospitalTask startTreatment = (string patientName) =>
            {
                Console.WriteLine("Doctor: Starting treatment for " + patientName);
            };

            string patient = "Rahul";

            registerPatient(patient);
            assignDoctor(patient);
            startTreatment(patient);
        }
    }
}
