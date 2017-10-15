using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            
            Osoba osoba = new Osoba();


            Console.ReadKey();
        }
    }
}
