using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input =  File
                .ReadAllLines(args[0])
                .Select(int.Parse)
                .ToList();
            var index = new HashSet<int>();
            
            var frequency = 0;
            index.Add(frequency);
            var frequency_found_twice = new Nullable<int>();
            while(!frequency_found_twice.HasValue)
            {
                using(var enumerator = input.GetEnumerator())
                {
                    while(!frequency_found_twice.HasValue && enumerator.MoveNext())
                    {
                        frequency += enumerator.Current;
                        if(index.Contains(frequency))
                        {
                            frequency_found_twice = frequency;
                        } else {
                            index.Add(frequency);
                        }
                    }
                }
            }
            Console.WriteLine(frequency_found_twice.Value);
        }
    }
}
