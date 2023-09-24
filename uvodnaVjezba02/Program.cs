using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, d, rezultat;

            a=10;
            b=7;
            c=12.5;
            d=16.7;
            rezultat=(a+b+c+d)/4;


            Console.WriteLine("Prosječna vrijednost varijabli a, b, c i d iznosi : " + rezultat);
            Console.ReadKey();
        }
    }
}
