/*
 Read two arrays of words and find the length of the largest common end (left or right).
*/

using System;

class UniversalConsoleApp
{
    static void Main(string[] args)
    {
        Console.Write("Enter any size for the first array: ");

        int size = int.Parse(Console.ReadLine()); 


        Console.WriteLine($"Enter elements in the first array with {size} size: ");

        string[] fisrt_arr = new string[size];

        for (int i = 0; i < size; ++i)
            fisrt_arr[i] = Console.ReadLine();

        Console.WriteLine("The first array is full... \n\n ------------------------------------------------");

        size = 0;

        Console.Write("Enter any size for the second array: ");

        size = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter elements in the second array with {size} size: ");

        string[] second_arr = new string[size]; 

        for (int i = 0; i < size; ++i)
            second_arr[i] = Console.ReadLine(); 

        Console.WriteLine("The second array is full... \n\n ------------------------------------------------");
        Console.WriteLine("result == {0}", theLengthoftheLargestCommonEnd(in fisrt_arr, in second_arr));
    }

    static int theLengthoftheLargestCommonEnd(in string[] f_arr, in string[] s_arr)
    {
        int max_count = 0, k = 0, idx_arr1 = 0, idx_arr2 = 0;

        for (int i = 0; i < f_arr.Length; ++i) 
        {
            for (int j = 0; j < s_arr.Length; ++j)
            {
                if (f_arr[i] == s_arr[j])
                {
                    idx_arr1 = i;
                    idx_arr2 = j;
                    ++k;
                    break;
                }
            }

            if (k > 0)
                break;
        }

        int R_idxArr1 = 0, R_idxArr2 = 0;
        k = 0;

        for (int i = f_arr.Length - 1; i >= idx_arr1; --i) 
        {
            for (int j = s_arr.Length - 1; j >= idx_arr2; --j)
            {
                if (f_arr[i] == s_arr[j])
                {
                    R_idxArr1 = i;
                    R_idxArr2 = j;
                    ++k;
                    break;
                }

                if (k > 0)
                    break;
            }

        }

        int left_side = 0, right_size = 0;

        for (int i = idx_arr1, j = idx_arr2; i <= R_idxArr1 || j < R_idxArr2; ++i, ++j) 
        {
            if (f_arr[i] == s_arr[j])
            {
                ++left_side;
            }
            else
            {
                break;
            }
        }

        for (int i = R_idxArr1, j = R_idxArr2; i >= idx_arr1 || j >= idx_arr2; --i, --j) 
        {
            if (f_arr[i] == s_arr[j])
            {
                ++right_size;
            }
            else
            {
                break;
            }
        }

        if (left_side > right_size)
            max_count = left_side;
        else if (right_size > left_side)
            max_count = right_size;
        else if (left_side == right_size)
            max_count = left_side = right_size;
        else { }

        return max_count;
    }
}


