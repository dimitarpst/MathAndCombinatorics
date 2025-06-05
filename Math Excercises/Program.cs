class Task1
{
    static void Main()
    {
        var parts = Console.ReadLine().Split();
        string s = parts[0];
        int fromBase = int.Parse(parts[1]);
        var value = Convert.ToInt32(s, fromBase);
        Console.WriteLine(value);
    }
}
