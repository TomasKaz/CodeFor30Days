namespace Day5
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < 11; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
            Console.ReadKey();
        }
    }
}
