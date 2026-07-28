using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale1 = new Sale(100, DateTime.Now);
            mySale1.Total = -125458751;
            Console.WriteLine(mySale1.Total);
        }
    }

    class Sale
    {
        //Atributos
        int total;
        DateTime date;

        //Propiedades
        public int Total { get { return total; } set { if (value < 0) value = 0; total = value; } }

        //Metodo Constructor
        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}
