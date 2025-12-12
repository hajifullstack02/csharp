using System;

namespace LambdaWithReturnTypes_Hospital
{
    // Delegates with different return types
    public delegate string TreatmentStart(string patientName);
    public delegate void TreatmentConfirm(string patientName);
    public delegate bool DoctorAvailability(string specialistType);

    class Program
    {
        static void Main()
        {
            // -----------------------------------------------
            // 1. Lambda with STRING return type
            // -----------------------------------------------

            TreatmentStart lambda_startTreatment = (string patientName) =>
            {
                return $"Doctor has started treatment for: {patientName}";
            };

            string result = lambda_startTreatment("Rahul");
            Console.WriteLine(result);



            // -----------------------------------------------
            // 2. Lambda with VOID return type
            // -----------------------------------------------

            TreatmentConfirm lambda_confirmTreatment = (string patientName) =>
            {
                Console.WriteLine($"Treatment confirmed for: {patientName}");
            };

            lambda_confirmTreatment("Rahul");



            // -----------------------------------------------
            // 3. Lambda with BOOL return type
            // -----------------------------------------------

            DoctorAvailability lambda_doctorAvailable = (string specialist) =>
            {
                string[] availableDoctors = { "Dentist", "Physician", "EyeSpecialist", "Cardiologist" };

                foreach (string doc in availableDoctors)
                {
                    if (doc == specialist)
                    {
                        return true;  // Doctor is available
                    }
                }
                return false;           // Doctor is not available
            };

            bool isAvailable = lambda_doctorAvailable("Dentist");

            Console.WriteLine("\nDoctor Available? " + isAvailable);



        }
    }
}
