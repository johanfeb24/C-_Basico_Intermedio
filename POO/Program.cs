using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el objeto de la Clase ventas
            Sale sale1= new Sale(100, DateTime.Now);
            Sale sale2= new Sale(200, DateTime.Now);
            sale1.Show();
            Console.WriteLine(sale1.GetInfo());
            Console.WriteLine(sale2.GetInfo());
        }
    }
    class Sale
    {
        //Atributos
        int total;
        DateTime date;

        //Metodo Constructor
        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }
    }
}
