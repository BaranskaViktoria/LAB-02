using System;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Write length n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("write array");
        string t;

        t = Console.ReadLine();

        char[] s = new char[] { ' ' };

        string[] subs = t.Split(s, StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[n]; int i = 0;
        foreach (var sub in subs)
        {
            num[i] = int.Parse(sub);
            i++;
        }

        int max = 1, count = 1;
        int q = 1, q1 = 1;

        for (int j = 0; j < (num.Length - 1); j++)
        {
            if (num[j] + 1 == num[j + 1])
            {
                count++;

                if (j == (num.Length - 2) && count != num.Length)
                {
                    if (max < count)
                    {
                        q1 = j + 2;
                        max = count + 1;
                        q = q1 - max;
                        count = 0;
                    }
                }
                else
                if (j == (num.Length - 2) && count == num.Length)
                {
                    q1= j + 2;
                    max = count;
                    q = q1- max;
                    count = 0;
                }
            }
            else
            {
                if (max < count)
                {
                    q1 = j + 1;
                    max = count;
                    q = q1 - max;
                    count = 0;
                }
            }
        }
        for (int j = q; j < q1; j++)
        {
            Console.Write($"{num[j]} ");

        }

    }
}