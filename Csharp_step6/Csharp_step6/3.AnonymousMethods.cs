using System;

namespace AnonymousMethods_Hospital
{
    // Delegate for hospital tasks
    delegate void HospitalTask(string details);

    class Program
    {
        static void Main()
        {
            // Anonymous method for registering the patient
            HospitalTask registerPatient = delegate (string patientName)
            {
                Console.WriteLine("Reception: Registering patient - " + patientName);
            };

            // Anonymous method for assigning doctor
            HospitalTask assignDoctor = delegate (string patientName)
            {
                Console.WriteLine("System: Assigning doctor to " + patientName);
            };

            // Anonymous method for starting treatment
            HospitalTask startTreatment = delegate (string patientName)
            {
                Console.WriteLine("Doctor: Starting treatment for " + patientName);
            };

            string patient = "Rahul";

            // Execute all tasks
            registerPatient(patient);
            assignDoctor(patient);
            startTreatment(patient);
        }
    }
}
