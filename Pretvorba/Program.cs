using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Csharp.TipoviOperatori
{
    class Osoba
    {
        public void Hodaj()
        {
            Console.WriteLine("Hodam");
        }
    }

    class Student : Osoba
    {
        public void PoložiIspit()
        {
            Console.WriteLine("Položio sam ispit");
        }
    }

    class NuklearniFizičar : Osoba
    {
        public void NapraviBombu()
        {
            Console.WriteLine("Bum");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // provjeriti što je od donjih inicijalizacija dozvoljeno
            Osoba osoba = new Osoba();
            Student student = new Student();
            NuklearniFizičar nuklFiz = new NuklearniFizičar();

            Osoba osobaStudent = new Student();
            Osoba osobaNuklFiz = new NuklearniFizičar();

            // provjeriti koja su od donjih pridruživanja dozvoljena
            osobaStudent = student;
            osobaNuklFiz = nuklFiz;

            student = osobaStudent;
            nuklFiz = osobaNuklFiz;

            // dodati sve moguće pozive metoda za objekt student


            // dodati sve moguće pozive metoda za objekt nuklFiz


            Osoba osobaS = student;
            // dodati sve moguće pozive metoda za osobaS


            Student sos = osobaS;
            // dodati sve moguće pozive metoda za sos


            Osoba osobaA = osobaNuklFiz;
            nuklFiz = (NuklearniFizičar)osobaA;
            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();

            osobaA = osoba;
            nuklFiz = (NuklearniFizičar)osobaA;
            nuklFiz.Hodaj();
            nuklFiz.NapraviBombu();

        }
    }
}
