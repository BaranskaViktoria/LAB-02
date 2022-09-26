using System;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Write  length n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("write array");
        string f;

        f = Console.ReadLine();

        char[] s = new char[] { ' ' };

        string[] subs = f.Split(s, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[n]; int i = 0;
        foreach (var sub in subs)
        {
            numbers[i] = int.Parse(sub);
            i++;
        }
        int max = 0;
        int t = 0;

        foreach (var num in numbers)
        {
            int count = numbers.Count(x => x == num);
            if (count > max)
            {
                max = count;
                t = num;
            }
        }

        Console.WriteLine(t);


    }
}