using System;

internal class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int n = (rnd.Next() % 3 + 1) * 4;

        //  Console.WriteLine(n); 

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next() % 10;

            Console.Write($"{arr[i]} ");
        }

        int n0 = n / 2, n1 = n / 4, n2 = n / 2 + n / 4;

        Console.WriteLine('\n');
        int[] arr0 = new int[n0];

        int j = 0;
        for (int i = 0; i < n0 / 2; i++)
        {
            arr0[j] = arr[i];

            j++;
        }

        for (int i = n2; i < n; i++)
        {

            arr0[j] = arr[i];
            j++;


        }

        int[] arr1 = new int[n0];

        int l = 0;
        for (int i = n1; i < n2; i++)
        {
            arr1[l] = arr[i];

            l++;
        }
        int[] arrs = new int[n0];


        for (int i = 0; i < n0; i++)
        {
            arrs[i] = arr0[i] + arr1[i];

        }


        for (int i = 0; i < n0; i++)
        {
            Console.Write($"{arrs[i]} ");

        }


    }
}