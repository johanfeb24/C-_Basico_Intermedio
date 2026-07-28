using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People()
            {
                Name = "Hector",
                Age = 34
            };
            
            People Hector = new People()
            {
                Name = "Hector",
                Age = 34
            };
            Console.WriteLine(People.Count);
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
        }
    }      
}
