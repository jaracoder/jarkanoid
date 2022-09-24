
using System;

namespace Jarkanoid
{
    class Creditos
    {
        public void MostrarCreditos()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Versión Arkanoid 2.0");
            Console.WriteLine("Juan Antonio Ripoll");

            Console.WriteLine();

            Console.WriteLine("Pulsa Esc para salir...");

        }
    }
}
