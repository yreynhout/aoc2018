using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = File.ReadAllLines(args[0]).Select(line => new BoxID(line)).ToArray();
            foreach(var left in boxes)
            {
                foreach(var right in boxes)
                {
                    if(left.DiffersByOnlyOneCharAtSamePosition(right))
                    {
                        Console.WriteLine(left.GetCommonCharacters(right));
                        Environment.Exit(0);
                    }
                }
            }
        }

        private class BoxID
        {
            private readonly string id;

            public BoxID(string id)
            {
                this.id = id ?? throw new ArgumentNullException(nameof(id));
            }

            public bool DiffersByOnlyOneCharAtSamePosition(BoxID other)
            {
                if (other == null)
                {
                    throw new ArgumentNullException(nameof(other));
                }

                var differences = 0;
                for(var index = 0; index < id.Length && index < other.id.Length; index++)
                {
                    if(!id[index].Equals(other.id[index])) differences++; 
                }
                return differences == 1;
            }

            public string GetCommonCharacters(BoxID other)
            {
                if (other == null)
                {
                    throw new ArgumentNullException(nameof(other));
                }

                var common = new List<char>();
                for(var index = 0; index < id.Length && index < other.id.Length; index++)
                {
                    if(id[index].Equals(other.id[index])) common.Add(id[index]); 
                }
                return new string(common.ToArray());
            }
        }
    }
}
