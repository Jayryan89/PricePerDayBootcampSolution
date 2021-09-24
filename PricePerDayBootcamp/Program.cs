using System;

namespace PricePerDayBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var CostOfBootcamp = 15500.0;
            var NumberOfDays = 65;
            var PricePerDay = CostOfBootcamp / NumberOfDays;
            Console.WriteLine($"The boot camp costs {PricePerDay} per day.");
        }
    }
}
