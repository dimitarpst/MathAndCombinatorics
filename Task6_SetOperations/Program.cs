using System;
using System.Linq;
using System.Collections.Generic;
class Task6
{
    static void Main()
    {
        var A = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
        var B = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
        var U = new HashSet<int>(A.Union(B));
        Console.WriteLine("Intersection: " + string.Join(" ", A.Intersect(B)));
        Console.WriteLine("Union: " + string.Join(" ", A.Union(B)));
        Console.WriteLine("A\\B: " + string.Join(" ", A.Except(B)));
        Console.WriteLine("B\\A: " + string.Join(" ", B.Except(A)));
        Console.WriteLine("Complement(A): " + string.Join(" ", U.Except(A)));
        Console.WriteLine("Complement(B): " + string.Join(" ", U.Except(B)));
    }
}
