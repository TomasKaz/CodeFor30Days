namespace Day3
{
    using System;

    public class Solution
    {
        public static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
                Console.WriteLine(@"Weird");
            else if (n >= 6 && n <= 20)
                Console.WriteLine(@"Weird");
            else
                Console.WriteLine(@"Not Weird");

            Console.ReadKey();
        }
    }
}
