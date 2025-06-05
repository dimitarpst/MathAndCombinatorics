using System;
using System.Linq;
using MathNet.Numerics;

class Task7
{
    static void Main()
    {
        var p = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = p[0], k = p[1];

        double perm = SpecialFunctions.Factorial(n) / SpecialFunctions.Factorial(n - k);

        double comb = Combinatorics.Combinations(n, k);

        double varr = perm;

        Console.WriteLine($"Permutations P({n},{k}) = {perm}");
        Console.WriteLine($"Combinations C({n},{k}) = {comb}");
        Console.WriteLine($"Variations V({n},{k}) = {varr}");
    }
}
