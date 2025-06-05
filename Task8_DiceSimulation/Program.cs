using System;
class Task8
{
    static void Main()
    {
        var rnd = new Random();
        int N = 100000;
        int[] cnt = new int[7];
        for (int i = 0; i < N; i++)
        {
            int d = rnd.Next(1, 7);
            cnt[d]++;
        }
        for (int i = 1; i <= 6; i++)
            Console.WriteLine($"{i}: {cnt[i] / (double)N:F4}");
    }
}
