using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            BasitDelege obj = new BasitDelege(Delegates2.Topla);
            obj();
            //Vergiler v = new Vergiler();
            //Console.WriteLine(v.GelirVergisi(v.BrütOku()));
        }
    }
    //class Vergiler
    //{
    //    public double BrütOku()
    //    {
    //        Console.WriteLine("brüt gelir gir:");
    //        return Double.Parse(Console.ReadLine());

    //    }
    //    public double GelirVergisi(double d)
    //    {
    //        if (d>20000)
    //        {
    //            return d * 0.40;
    //        }
    //        else
    //        {
    //            return d * 0.25;
    //        }
    //    }
    //}
}
