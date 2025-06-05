using System;
using System.Linq;
using MathNet.Numerics.Statistics;

class Task2
{
    static void Main()
    {
        var a = Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToArray();

        double mean = ArrayStatistics.Mean(a);

        var groups = a.GroupBy(x => x)
                      .Select(g => new { Value = g.Key, Count = g.Count() });
        double mode = groups.OrderByDescending(g => g.Count)
                            .First()
                            .Value;

        double median;
        var sorted = a.OrderBy(x => x).ToArray();
        int n = sorted.Length;
        if (n % 2 == 1)
        {
            median = sorted[n / 2];
        }
        else
        {
            median = (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
        }

        Console.WriteLine($"Mean: {mean:F4}");
        Console.WriteLine($"Mode: {mode}");
        Console.WriteLine($"Median: {median:F4}");
    }
}
