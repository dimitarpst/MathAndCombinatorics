using System;
using MathNet.Numerics.LinearAlgebra.Double;
class Task3
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
        if (nums.Length < 9)
        {
            var more = Console.ReadLine().Split().Select(double.Parse);
            nums = nums.Concat(more).ToArray();
        }
        var M = DenseMatrix.OfArray(new double[,] {
            { nums[0], nums[1], nums[2] },
            { nums[3], nums[4], nums[5] },
            { nums[6], nums[7], nums[8] }
        });
        Console.WriteLine(M.Determinant());
    }
}
