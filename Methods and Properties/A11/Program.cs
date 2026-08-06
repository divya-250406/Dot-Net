using System;

class Stock
{
    string sn;
    string ss;
    double pcp;
    double ccp;

    public Stock(string name, string symbol, double pp, double cp)
    {
        sn=name;
        ss=symbol;
        pcp=pp;
        ccp=cp;
    }

    public double GetChangePercentage()
    {
        return ((ccp - pcp) / pcp) * 100;
    }

    public void Display()
    {
        Console.WriteLine("Stock Name : " + sn);
        Console.WriteLine("Stock Symbol : " + ss);
        Console.WriteLine("Previous Closing Price : " + pcp);
        Console.WriteLine("Current Closing Price : " + ccp);
        Console.WriteLine("Percentage Change : " + GetChangePercentage() + "%");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Stock Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Stock Symbol: ");
        string symbol = Console.ReadLine();

        Console.Write("Enter Previous Closing Price: ");
        double previous = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Current Closing Price: ");
        double current = Convert.ToDouble(Console.ReadLine());

        Stock stock = new Stock(name, symbol, previous, current);

        stock.Display();
    }
}

