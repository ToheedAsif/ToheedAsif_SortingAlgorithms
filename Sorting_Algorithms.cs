using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Sorting_Algorithms
{
    public List<int> Merge_Sort(List<int> numbers)
    {
        // Base case - if the list has 0 or 1 element, it is already sorted
        // Return the list as is
        if (numbers.Count <= 1)
        {
            return numbers;
        }

        // Split the list into two halves (left and right)
        // You will need to find the middle index and divide the list into two sublists
        int middle = (numbers.Count / 2);
        
        // Recursively call Merge_Sort on each half to sort them individually
        // The idea is to keep splitting until we reach lists of size 1

        // Merge the two sorted halves back together

        // Step 5: Return the merged sorted list
        List<int> sorted = new List<int>();
        return sorted;
    }

    // Merge two sorted lists into one sorted list
    public List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        return result;
    }
}
