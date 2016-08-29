namespace Day6
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            var s = new string[t];

            for (var i = 0; i < t; i++)
            {
                s[i] = Console.ReadLine();
            }

            for (var i = 0; i < t; i++)
            {
                for (var j = 0; j < s[i].Length; j++)
                {
                    if (j % 2 == 0) Console.Write(s[i][j]);
                }

                Console.Write(@" ");

                for (var j = 0; j < s[i].Length; j++)
                {
                    if (j % 2 == 1) Console.Write(s[i][j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
