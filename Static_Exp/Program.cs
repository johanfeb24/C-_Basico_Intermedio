using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People()
            {
                Name = "Johan",
                Age = 36
            };
            Console.WriteLine(People.Count);
            Console.WriteLine(People.GetCount());
        }

        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Total People: {Count}";
            }
        }          
    }
}
