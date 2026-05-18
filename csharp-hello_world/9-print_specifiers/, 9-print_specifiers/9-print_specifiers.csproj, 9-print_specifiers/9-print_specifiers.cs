using System;

class Program
{
    static void Main(string[] args)
    {
        double numberPercent = .7553;
        double numberMoney = 98765.4321;
        Console.WriteLine("Percent: {0:P2}", numberPercent);
        Console.WriteLine("Currency: {0:C2}", numberMoney);
    }
}
