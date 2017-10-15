using System;

namespace Vsite.CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ispisati duljinu tipa decimal

            // ispisati duljinu tipa double

            // ispisati duljinu tipa MojaStruktura

            // ispisati duljinu tipa MojaSloženaStruktura

            // ispisati duljinu tipa MojaKlasa

            Console.ReadKey();
        }
    }
}
