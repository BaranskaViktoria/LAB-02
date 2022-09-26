using System;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("write array_1");
        string arr1;

        arr1 = Console.ReadLine();
        char[] arrr1 = new char[256];


        char[] s = new char[] { ' ' };

        string[] subs1 = arr1.Split(s, StringSplitOptions.RemoveEmptyEntries);
        int i = 0;
        foreach (var sub in subs1)
        {
            arrr1[i] = char.Parse(sub);
            i++;
        }

        Console.WriteLine("write array_2");
        string arr;

        arr = Console.ReadLine();
        char[] arrr = new char[256];



        string[] subs = arr.Split(s, StringSplitOptions.RemoveEmptyEntries);
        int j = 0;
        foreach (var sub in subs)
        {
            arrr[j] = char.Parse(sub);
            j++;
        }

        if (arrr[0] < arr1[0])
        {
            for (int d = 0; d < arrr.Length; d++)
            {
                Console.Write($"{arrr[d]}");
            }
            Console.WriteLine();
            for (int d = 0; d < arrr1.Length; d++)
            {
                Console.Write($"{arrr1[d]}");
            }
        }
        else
        {
            for (int d = 0; d < arrr1.Length; d++)
            {
                Console.Write($"{arrr1[d]}");
            }
            Console.WriteLine();
            for (int d = 0; d < arrr.Length; d++)
            {
                Console.Write($"{arrr[d]}");
            }


        }

    }
}
