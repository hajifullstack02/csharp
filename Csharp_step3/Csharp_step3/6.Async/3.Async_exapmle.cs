using System;
using System.Threading.Tasks;

namespace AsyncTravelBooking
{
    class TravelAgency
    {
        public static async Task BookTaxiAsync()
        {
            Console.WriteLine("Booking Taxi...");
            await Task.Delay(4000); // Takes 4 seconds
            Console.WriteLine("Taxi booked successfully.");
        }

        public static async Task BookFlightAsync()
        {
            Console.WriteLine("Booking Flight...");
            await Task.Delay(7000); // Takes 7 seconds
            Console.WriteLine("Flight booked successfully.");
        }

        public static async Task BookHotelAsync()
        {
            Console.WriteLine("Booking Hotel...");
            await Task.Delay(5000); // Takes 5 seconds
            Console.WriteLine("Hotel booked successfully.");
        }
    }

    class Program
    {
        public static async Task Main()
        {
            // Sequential example (uncomment to test)
            // await TravelAgency.BookTaxiAsync();
            // await TravelAgency.BookFlightAsync();
            // await TravelAgency.BookHotelAsync();

            // Concurrent execution
            Task taxiTask = TravelAgency.BookTaxiAsync();
            Task flightTask = TravelAgency.BookFlightAsync();
            Task hotelTask = TravelAgency.BookHotelAsync();

            await Task.WhenAll(taxiTask, flightTask, hotelTask);

            Console.WriteLine("All bookings completed!");
        }
    }
}
