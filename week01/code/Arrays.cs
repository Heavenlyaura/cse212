public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // SOLUTION
        // Create a list passing the length as the size of the list
        // Loop through the list 
        // Multiply the number by the current (index++) and add to the list in each iteration
        // Return the list
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

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // SOLUTION
        // Ensure the "Amount is not greater than the length of the list
        // The number of items in the list will be denoted with n & the amount with K
        // The list will be split into two parts:
        // 1. The first part will be the last K items (from n-K to n-1)
        // 2. The second part will be the first n-K items (from 0 to n-K-1)
        // Clear the original list
        // Combine the two parts: last 'amount' elements first, then the rest

        var n = data.Count;
        var k = amount % n;

        var part1 = data.GetRange(n - k, k);
        var part2 = data.GetRange(0, n - k);

        data.Clear();
        data.AddRange(part1);
        data.AddRange(part2);
    }
}
