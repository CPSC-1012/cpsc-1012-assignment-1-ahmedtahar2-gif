using System;

namespace DragonHatcherySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dragon Hatchery Simulator!");

            // Get user inputs with basic validation
            Console.Write("Enter the initial number of dragons: ");
            if (!int.TryParse(Console.ReadLine(), out int initialDragons) || initialDragons < 0)
            {
                Console.WriteLine("Error: Please enter a valid non-negative integer.");
                return;
            }

            Console.Write("Enter the daily growth rate (%): ");
            if (!double.TryParse(Console.ReadLine(), out double growthRatePercent) || growthRatePercent < 0)
            {
                Console.WriteLine("Error: Please enter a valid non-negative number.");
                return;
            }

            Console.Write("Enter the number of weeks: ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfWeeks) || numberOfWeeks < 0)
            {
                Console.WriteLine("Error: Please enter a valid non-negative integer.");
                return;
            }

            // Convert inputs for calculation
            double growthRate = growthRatePercent / 100;  // Convert % to decimal
            int days = numberOfWeeks * 7;                 // Convert weeks to days

            // Calculate projected number of dragons using exponential growth
            double finalDragons = initialDragons * Math.Pow(1 + growthRate, days);

            // Round to nearest whole number
            long finalDragonsRounded = (long)Math.Round(finalDragons);

            // Display result
            Console.WriteLine($"\nAfter {days} days, there will be approximately {finalDragonsRounded} dragons in the hatchery.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    }

