using System;

namespace DelegateWithReturns_Hospital
{
    // Delegate that returns a string (treatment message)
    public delegate string TreatmentProcess(string patientName);

    // Delegate that returns void (final confirmation)
    public delegate void TreatmentConfirmation(string patientName);

    // Delegate that returns bool (check doctor availability)
    public delegate bool DoctorAvailability(string doctorType);


    class Hospital
    {
        // Returns a message that treatment is being prepared
        public string StartTreatment(string patientName)
        {
            return $"Doctor has started treatment for: {patientName}";
        }

        // Confirm treatment completion
        public void ConfirmTreatment(string patientName)
        {
            Console.WriteLine($"Treatment completed and confirmed for: {patientName}");
        }

        // Check if doctor is available using foreach loop
        public bool CheckDoctorAvailability(string doctorType) // "Dentist"
        {
            string[] availableDoctors = { "Physician", "EyeSpecialist", "Dentist", "Cardiologist" };

            foreach (var doctor in availableDoctors)
            {
                if (doctor == doctorType)
                {
                    return true;
                }
            }
            return false;
        }
    }



    class Program
    {
        static void Main()
        {
            Hospital hospital = new Hospital();

            // Create delegate objects
            TreatmentProcess tProcess = hospital.StartTreatment;
            TreatmentConfirmation tConfirm = hospital.ConfirmTreatment;
            DoctorAvailability dAvailable = hospital.CheckDoctorAvailability;

            // Patient 1
            string patientName = "Rahul";
            string doctorNeeded = "Dentist";

            Console.WriteLine("Checking doctor availability...");

            bool isAvailable = dAvailable(doctorNeeded);
            if (isAvailable)
            {
                // Get message from delegate (string return)
                string message = tProcess(patientName);
                Console.WriteLine(message);

                // Confirm treatment
                tConfirm(patientName);
            }

            // Patient 2
            string patientName2 = "Meena";
            string doctorNeeded2 = "Neurologist"; // Not available

            Console.WriteLine("\nChecking doctor availability...");
            bool isAvailable2 = dAvailable(doctorNeeded2);

            if (isAvailable2)
            {
                string message = tProcess(patientName2);
                Console.WriteLine(message);

                tConfirm(patientName2);
            }
            else
            {
                Console.WriteLine($"Doctor '{doctorNeeded2}' is not available.");
            }
        }
    }
}
