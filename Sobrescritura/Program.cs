using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una venta normal
            Sale normalSale = new Sale(100, "Laptop");
            Console.WriteLine("=== Venta Normal ===");
            Console.WriteLine(normalSale.GetInfo());
            Console.WriteLine("Total: $" + normalSale.CalculateTotal());
            Console.WriteLine();

            // Crear una venta con descuento
            DiscountedSale discountSale = new DiscountedSale(100, "Laptop", 20);
            Console.WriteLine("=== Venta con Descuento ===");
            Console.WriteLine(discountSale.GetInfo());
            Console.WriteLine("Total: $" + discountSale.CalculateTotal());
            Console.WriteLine();

            // Crear una venta al por mayor
            WholesaleSale wholesaleSale = new WholesaleSale(100, "Laptop", 15);
            Console.WriteLine("=== Venta al por Mayor ===");
            Console.WriteLine(wholesaleSale.GetInfo());
            Console.WriteLine("Total: $" + wholesaleSale.CalculateTotal());

            Console.ReadKey();
        }
    }

    // Clase base (padre)
    class Sale
    {
        // Campos protegidos (accesibles desde clases hijas)
        protected decimal price;
        protected string product;

        // Constructor
        public Sale(decimal price, string product)
        {
            this.price = price;
            this.product = product;
        }

        // Método VIRTUAL (puede ser sobrescrito por clases hijas)
        public virtual decimal CalculateTotal()
        {
            return price;
        }

        // Método VIRTUAL para mostrar información
        public virtual string GetInfo()
        {
            return $"Producto: {product}, Precio: ${price}";
        }
    }

    // Clase derivada 1: Venta con descuento
    class DiscountedSale : Sale
    {
        private decimal discountPercentage;

        public DiscountedSale(decimal price, string product, decimal discountPercentage) 
            : base(price, product)
        {
            this.discountPercentage = discountPercentage;
        }

        // SOBRESCRITURA del método CalculateTotal
        public override decimal CalculateTotal()
        {
            decimal discount = price * (discountPercentage / 100);
            return price - discount;
        }

        // SOBRESCRITURA del método GetInfo
        public override string GetInfo()
        {
            // Llama al método de la clase base con 'base'
            return base.GetInfo() + $", Descuento: {discountPercentage}%";
        }
    }

    // Clase derivada 2: Venta al por mayor
    class WholesaleSale : Sale
    {
        private decimal taxPercentage;

        public WholesaleSale(decimal price, string product, decimal taxPercentage) 
            : base(price, product)
        {
            this.taxPercentage = taxPercentage;
        }

        // SOBRESCRITURA del método CalculateTotal
        public override decimal CalculateTotal()
        {
            decimal tax = price * (taxPercentage / 100);
            return price + tax;
        }

        // SOBRESCRITURA del método GetInfo
        public override string GetInfo()
        {
            return base.GetInfo() + $", Impuesto: {taxPercentage}%";
        }
    }
}
