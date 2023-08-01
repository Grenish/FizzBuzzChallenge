using System;

public class FizzBuzz
{
    public static void fizzbuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Main(string[] args)
    {
        // Test the function for numbers from 1 to 20
        fizzbuzz(20);
    }
}
