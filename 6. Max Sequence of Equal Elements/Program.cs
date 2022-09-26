using System;


internal class Program
{
    static void Main()
    {
        Console.WriteLine("Write length number");
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

        int maxcoun = 1, count = 1;
        int k1 = 0, k2 = 0;

        int num = numbers[0];
        for (int j = 1; j < numbers.Length; j++)
        {
            if (numbers[j] == num)
            {

                count++;


            }
            else
            {
                num = numbers[j];
                if (maxcoun <= count)
                {
                    k2 = j;


                    maxcoun = count;
                    k1 = k2 - maxcoun - 1;
                    count = 0;
                }
            }
        }
        for (int j = k1; j < k2 + count; j++)
        {
            Console.Write($"{numbers[j]} ");

        }



    }
}