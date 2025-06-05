using System;
using System.Linq;
class Task5
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double minLen = double.PositiveInfinity;
        for (int i = 0; i < N; i++)
        {
            var v = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double len = Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);
            if (len < minLen) minLen = len;
        }
        Console.WriteLine(minLen);
    }
}
