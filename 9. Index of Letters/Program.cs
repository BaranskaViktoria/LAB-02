using System;

internal class Program
{
    static void Main()
    {

        Console.WriteLine("write wourd");
        string n;

        n = Console.ReadLine();

        for (int i = 0; i < n.Length; i++)
        {
            Console.WriteLine($"{n[i]} - - -> {n[i] - 97}");

        }

    }
}