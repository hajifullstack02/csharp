using System;

namespace HospitalDelegateExample
{
    // Delegate declaration
    public delegate void TreatmentSection(string patientName);

    class Hospital
    {
        // Method for General Checkup
        public void GeneralCheckup(string patientName)
        {
            Console.WriteLine($"General Physician is treating: {patientName}");
        }

        // Method for Eye Treatment
        public void EyeTreatment(string patientName)
        {
            Console.WriteLine($"Eye Specialist is treating: {patientName}");
        }

        // Method for Dental Treatment
        public void DentalTreatment(string patientName)
        {
            Console.WriteLine($"Dentist is treating: {patientName}");
        }
    }


    class Patient
    {
        static void Main()
        {
            Hospital hospital = new Hospital();

            // "Receptionist" works as a delegate
            TreatmentSection receptionist;

            Console.WriteLine("\nPatient comes for general checkup...");
            receptionist = hospital.GeneralCheckup;   // delegate points to method
            receptionist("Rahul");                    // call delegate

            Console.WriteLine("\nPatient has eye issues...");
            receptionist = hospital.EyeTreatment;     // delegate now points to another method
            receptionist("Sunita");

            Console.WriteLine("\nPatient has tooth pain...");
            receptionist = hospital.DentalTreatment;  // delegate changes again
            receptionist("Arjun");
        }
    }
}
