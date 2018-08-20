using System;
using FSharpLib;

namespace CSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var yrHour = Yr.GetForecastKristiansand();
            Console.WriteLine("Sunset hour: " + yrHour.ToString());
            Console.ReadLine();
        }
    }
}
