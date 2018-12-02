using System;
using System.IO;
using System.Linq;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var exactly_twos = 0;
            var exactly_threes = 0;
            foreach(var line in File.ReadAllLines(args[0]))
            {
                var line_chars = line.Distinct().ToArray();
                var exactly_two_of_any_letter = false;
                var exactly_three_of_any_letter = false;
                foreach(var line_char in line_chars)
                {
                    var appears = line.Count(current => current.Equals(line_char));
                    if(appears == 2) exactly_two_of_any_letter = true;
                    if(appears == 3) exactly_three_of_any_letter = true;
                }
                if(exactly_two_of_any_letter) exactly_twos++;
                if(exactly_three_of_any_letter) exactly_threes++;
            }
            Console.WriteLine(exactly_twos * exactly_threes);
        }
    }
}
