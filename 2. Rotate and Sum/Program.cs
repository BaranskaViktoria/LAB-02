using System;


internal class Program
{
    static void Main()
    {
        Console.WriteLine("write length of the array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("write array");
        string t;

        t = Console.ReadLine();


        char[] s = new char[] { ' ' };

        string[] subs = t.Split(s, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[n]; int i = 0;
        foreach (var sub in subs)
        {
            numbers[i] = int.Parse(sub);
            i++;
        }

        Console.WriteLine("write how many times rotate the array ");
        int rt = int.Parse(Console.ReadLine());


        for (int j = 0; j < rt; j++)
        {
            int num = numbers[n - 1];
            for (int k = n - 1; k != 0; k--)
            {
                numbers[k] = numbers[k - 1];
            }
            numbers[0] = num;

            for (int f = 0; f < n; f++)
            {
                Console.Write($"{numbers[f]} ");
            }
            Console.WriteLine();
        }

        Console.Write("sum ");

        int sum = 1;
        for (int k = 0; k < n; k++)
        {
            sum = sum * numbers[k];
        }
        Console.Write($"{sum}");



    }
}
