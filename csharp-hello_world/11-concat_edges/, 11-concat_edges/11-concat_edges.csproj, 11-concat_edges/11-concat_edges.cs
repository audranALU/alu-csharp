using System;
class Program
{
    static void Main(string[] args)
    {
        string str = "C# is fun!";
        Console.WriteLine(str.Substring(5, 6)
        + str.Substring(2, 2)
        + str.Substring(8, 4));
    }
}
