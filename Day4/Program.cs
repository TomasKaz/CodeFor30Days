namespace Day4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        private int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0."); // Not L10N
                this.age = 0;
            }
            else this.age = initialAge;
        }

        public void YearPasses()
        {
            this.age++;
        }

        public void AmIOld()
        {
            if (this.age < 13)
                Console.WriteLine("You are young."); // Not L10N
            else if (this.age < 18)
                Console.WriteLine("You are a teenager."); // Not L10N
            else 
                Console.WriteLine("You are old."); // Not L10N
        }
    }
}
