using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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

        //In order to solve the problem, we need to create a new dynamic array because we don't know what the length will be in this case.
        //We need to create a loop that stores a value of 1 to 'i' because we will multiply the number by that value and can't have it start at 0. 
        //It needs to loop the same amount of times as the given length.
        //The value stored inside 'i' will increment by one every time it loops.
        //It needs to multiply the number by i each time it goes through the loop.
        //The result of the multiplication problem needs to be added into the array.

        var multiples = new List<double>();

        for (int i = 1; i <= length; i++ )
        {
           multiples.Add(number * i);
        }

        return multiples.ToArray();
// replace this return statement with your own
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

        // We need to get the specific range that needs to be rotated.
        // We do this by first finding the correct index using Count to find the length of the array and subtract the amount from it.
        // Then using this index we need to get the range. We use the index we just got and the amount we need to take from the data.
        // Now that we have the data, we can remove it from the list and then add the new range back to the beginning of the data.
        
        int index = data.Count() - amount;
        List<int> RangeOne = data.GetRange(index, amount);
        data.RemoveRange(index, amount);
        data.InsertRange(0, RangeOne);
        //
    }
}
