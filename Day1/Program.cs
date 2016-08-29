namespace Day1
{
using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

// END OF LOCKED SOURCE

        // Declare second integer, double, and String variables.
        int ii;
        double dd;
        string ss;

        // Read and save an integer, double, and String to your variables.
        ii = Convert.ToInt32(Console.ReadLine());
        dd = Convert.ToDouble(Console.ReadLine());
        ss = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + ii);

        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + dd).ToString(@"f1"));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + ss);
        
        // START OF LOCKED CODE
        Console.ReadKey();
    }
}

// END OF LOCKED CODE
}