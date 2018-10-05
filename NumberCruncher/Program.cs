using System;
using NumberUtility;
using System.Collections.Generic;

namespace NumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCruncher numberCruncher = new NumberCruncher();

            numberCruncher.Run();
            Console.ReadLine();
        }
    }
}
