using System;
using System.Diagnostics;

public class AssertionsHomework
{
    private const string IsMandatory = "is mandatory";
    private const string ArrayMustNotBeEmpty = "Array must not be empty";
    private const string StartIndexConstrains = "Start index must be equal or greater than 0 and less than the arrays length";
    private const string EndIndexConstrains = "End index must be greater than start index and less than the array length";

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array" + IsMandatory);
        Debug.Assert(arr.Length > 0, ArrayMustNotBeEmpty);
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }   

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array " + IsMandatory);
        Debug.Assert(arr.Length > 0, ArrayMustNotBeEmpty);
        var result = BinarySearch(arr, value, 0, arr.Length - 1);
        return result;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array " + IsMandatory);
        Debug.Assert(arr.Length > 0, ArrayMustNotBeEmpty);
        Debug.Assert(value != null, "Value ", IsMandatory);
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length, StartIndexConstrains);
        Debug.Assert(endIndex < arr.Length && startIndex < endIndex, EndIndexConstrains);

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Debug.Assert(
            midIndex >= 0 && midIndex < arr.Length,
            "Mid index must be greater than start index and less than the array length");
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
       where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array " + IsMandatory);
        Debug.Assert(arr.Length > 0, ArrayMustNotBeEmpty);
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length, StartIndexConstrains);
        Debug.Assert(endIndex < arr.Length && startIndex < endIndex, EndIndexConstrains);
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(
            minElementIndex >= 0 && minElementIndex < arr.Length,
            "Min element index must be greater than start index and less than the array length");
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null, "X " + IsMandatory);
        Debug.Assert(y != null, "Y " + IsMandatory);
        T oldX = x;
        x = y;
        y = oldX;
    }    
}
