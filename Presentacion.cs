using System;

namespace Jarkanoid
{
    class Presentacion
    {
        static void Main(string[] args)
        {
            Partida nuevaPartida = new Partida();
            Creditos c = new Creditos();
            Ayuda a = new Ayuda();
            bool salirIntro = false;
            ConsoleKeyInfo key;
            do
            {

                dibujarPiramide();

                Console.SetCursorPosition(0, 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Banner.Escribir(" JARKANOID ");


                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(22, 20);
                Console.WriteLine("Presione Intro o Barra Espaciadora ");
                
                Console.SetCursorPosition(26, 21);
                Console.WriteLine("para empezar la partida");


                
                Console.SetCursorPosition(1, 23);
                Console.WriteLine("C -> Creditos");
                
                Console.SetCursorPosition(69, 23);
                Console.WriteLine("S -> Salir");


                key = Console.ReadKey();

                if (key.Key.Equals(ConsoleKey.Spacebar) ||
                    key.Key.Equals(ConsoleKey.Enter)) 
                {
                    salirIntro = true;
                    nuevaPartida.NuevaPartida();
                }

                if (key.Key.Equals(ConsoleKey.C))
                {
                    c.MostrarCreditos();
                }

                if (key.Key.Equals(ConsoleKey.A))
                {
                    a.MostrarAyuda();
                }

                if (key.Key.Equals(ConsoleKey.S))
                {
                    salirIntro = true;
                }
            }
            while(salirIntro == false);
        }


        private static void dibujarPiramide()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(0, 17);
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write(Constantes.LADRILLO);
                i += 4;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 16);
            for (int i = 0; i < Console.BufferWidth - 10; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 20))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }

            Console.SetCursorPosition(10, 15);
            for (int i = 0; i < Console.BufferWidth - 20; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 30))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }

            Console.SetCursorPosition(15, 14);
            for (int i = 0; i < Console.BufferWidth - 30; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 40))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }

            Console.SetCursorPosition(20, 13);
            for (int i = 0; i < Console.BufferWidth - 35; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 45))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 5;
            }

            Console.SetCursorPosition(25, 12);
            for (int i = 0; i < Console.BufferWidth - 50; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 60))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }

            Console.SetCursorPosition(30, 11);
            for (int i = 0; i < Console.BufferWidth - 60; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 70))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }



            Console.SetCursorPosition(35, 10);
            for (int i = 0; i < Console.BufferWidth - 70; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 80))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }

            Console.SetCursorPosition(40, 9);
            for (int i = 0; i < Console.BufferWidth - 80; i++)
            {
                if ((i == 0) || (i > Console.BufferWidth - 90))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(Constantes.LADRILLO);
                i += 4;
            }
        }

    }
}
