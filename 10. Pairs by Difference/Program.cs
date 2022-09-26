using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write length n");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.Write("Write  n  ");
        int number = int.Parse(Console.ReadLine());
        int n = 0, count = 0;

        for(int i = 0; i<arr.Length; ++i)
        {
            n = arr[i];

            for(int j = i; j<arr.Length; ++j)
            {
                if ((arr[j]-n == number) || (n - arr[j] == number))
                {
                    ++count;
                }
            }

        }

        Console.WriteLine("count: " + count);
    }
}