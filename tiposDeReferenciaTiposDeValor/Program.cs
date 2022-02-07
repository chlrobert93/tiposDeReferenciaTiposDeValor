using System;

struct Puntero { public int x, y; }

namespace tiposDeReferenciaTiposDeValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puntero p1 = new Puntero();
            p1.x = 1;

            //La asignación genera una copia

            Puntero p2 = p1;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            //Cambiar p1.x

            p1.x = 2;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

        }
    }
}
