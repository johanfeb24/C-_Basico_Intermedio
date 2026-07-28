using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //Console.WriteLine(b.Hi());
        }
    }
}

public class Sale
{
    private decimal[] _amounts;
    private int _n;
    private int _end;

    public Sale(int n)
    {
        _amounts = new decimal[n];
        _n = n;
        _end = 0;
    }

    public void Add(decimal amount)
    {
        if (_end < _n)
        {
            _amounts[_end] = amount;
            _end++;
        }
    }
    public virtual decimal GetTotal()
    {

    }
}
/*public class A
{
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}
public class B : A
{
    public override string Hi()
    {
        return base.Hi()+ "Hola soy B";
    }
}*/
