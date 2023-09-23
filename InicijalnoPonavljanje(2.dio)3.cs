using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje(2.dio)3
{
    class Vozilo
    {
        bool Leti, Plovi;
    
        public bool Leti { get => Leti; set => Leti = value; }
        public bool Plovi { get => Plovi; set => Plovi = value; }
    
        public void KudaVozi()
        {
            Console.WriteLine("Da li leti: " + Leti + "\n" + "Da li plovi: " + Plovi);
        }
    }
    class Brod : Vozilo
    {
        public Brod()
        {
            Plovi = true;
        }
    }
    class Zrakoplov : Vozilo
    {
        public Zrakoplov()
        {
            Leti = true;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();
    
            Console.WriteLine("Brod");
            brod.KudaVozi();
            Console.WriteLine("Zrakoplov");
            zrakoplov.KudaVozi();
    
            Console.ReadKey();
        }
    }
}