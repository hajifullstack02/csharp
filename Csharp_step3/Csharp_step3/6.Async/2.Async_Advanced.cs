using System;
using System.Threading.Tasks;

namespace AsyncRestaurantExample
{
    class Kitchen
    {
        public static async Task PrepareStarterAsync()
        {
            var start = DateTime.Now;
            Console.WriteLine($"Starter preparation started at {start}");
            await Task.Delay(2000); // 2 seconds
            var end = DateTime.Now;
            Console.WriteLine($"Starter ready! Took: {end - start}");
        }

        public static async Task PrepareMainCourseAsync()
        {
            var start = DateTime.Now;
            Console.WriteLine($"Main course preparation started at {start}");
            await Task.Delay(5000); // 5 seconds
            var end = DateTime.Now;
            Console.WriteLine($"Main course ready! Took: {end - start}");
        }

        public static async Task PrepareDessertAsync()
        {
            var start = DateTime.Now;
            Console.WriteLine($"Dessert preparation started at {start}");
            await Task.Delay(3000); // 3 seconds
            var end = DateTime.Now;
            Console.WriteLine($"Dessert ready! Took: {end - start}");
        }
    }

    class Restaurant
    {
        public static async Task ProcessOrderAsync()
        {
            Console.WriteLine("=== Sequential Order Processing ===");

            var seqStart = DateTime.Now;

            // Sequential processing
            await Kitchen.PrepareStarterAsync();
            await Kitchen.PrepareMainCourseAsync();
            await Kitchen.PrepareDessertAsync();

            var seqEnd = DateTime.Now;
            Console.WriteLine($"Sequential time: {(seqEnd - seqStart).TotalSeconds} seconds\n");

            Console.WriteLine("=== Concurrent Order Processing ===");

            var conStart = DateTime.Now;

            // Concurrent / Parallel execution
            Task starter = Kitchen.PrepareStarterAsync();
            Task mainCourse = Kitchen.PrepareMainCourseAsync();
            Task dessert = Kitchen.PrepareDessertAsync();

            await Task.WhenAll(starter, mainCourse, dessert);

            var conEnd = DateTime.Now;
            Console.WriteLine($"Concurrent time: {(conEnd - conStart).TotalSeconds} seconds");
        }
    }

    class Program
    {
        static async Task Main()
        {
            await Restaurant.ProcessOrderAsync();
        }
    }
}
