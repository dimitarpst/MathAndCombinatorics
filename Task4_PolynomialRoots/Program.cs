using System;
using MathNet.Numerics.RootFinding;
using MathNet.Numerics;
using System.Numerics;
class Task4
{
    static void Main()
    {
        var c = Console.ReadLine().Split().Select(double.Parse).Reverse().ToArray();
        var roots = FindRoots.Polynomial(c);
        foreach (var r in roots)
            Console.WriteLine(r);
    }
}
