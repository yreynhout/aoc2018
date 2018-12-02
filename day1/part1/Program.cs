using System;
using System.IO;
using System.Linq;

namespace day1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                File
                    .ReadAllLines(args[0])
                    .Select(int.Parse)
                    .Aggregate(0, (frequency, change) => frequency + change)
            );
        }
    }
}
