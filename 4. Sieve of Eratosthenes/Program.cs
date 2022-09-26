using System;


internal class Program
{
    static void Main()
    {
        Console.WriteLine(" int n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i < n; i++)
        {
            if ((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) && (i % 7 != 0) || i == 2 || i == 3 || i == 5 || i == 7)

                Console.Write($"{i} ");


        }

    }
}
