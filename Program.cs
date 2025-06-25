using System;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2025, 06, 24, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        String s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(10));
    }
}