using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects

        Console.WriteLine("Hello Sandbox World!");

        double[] list = MultiplesOf(7, 5);
        // { 7, 14, 21, 28, 35 }

        Console.WriteLine(string.Join(", ", list));

    }

    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // SOLUTION
        // Check if lenth is a positive number return[0] if not
        // create a list passing the length as the size of the list
        // loop through the list 
        //  Multiply the number by the current index++ and add to the list in each iteration
        // return the list
        // Peformance Complexity is O(n)
        // Space Complexity is O(n)

        double[] list = new double[length];

        for (int i = 0; i < list.Length; i++)
        {
            var multiple = number * (i + 1);
            list[i] = multiple;
            Console.WriteLine(multiple);
        }
        return list;
    }
}