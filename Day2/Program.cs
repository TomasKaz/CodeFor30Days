namespace Day2
{
    using System;

    public class Solution
    {
        public static void Main(string[] args)
        {
            var mealCost = Convert.ToDouble(Console.ReadLine());
            var tipPercent = Convert.ToInt32(Console.ReadLine());
            var taxPercent = Convert.ToInt32(Console.ReadLine());

            var totalCost = mealCost * (1 + tipPercent/100.0 + taxPercent/100.0);

            Console.WriteLine($"The total meal cost is {totalCost.ToString(@"F0")} dollars.");

            Console.ReadKey(); // TO BE REMOVED WHEN SENDING
        }
    }
}