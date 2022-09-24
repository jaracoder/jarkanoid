
using System;
using System.Threading;
namespace Jarkanoid
{
    class Tablero
    {
        private Ladrillo[,] ladrillos;
        private Pala pala;
        private Pelota pelota;

        private Estado estado;
        public enum Estado 
        {
            INICIO,
            PAUSADO,
            JUGANDO,
            GANADOR,
            PERDEDOR,
            FIN
        }


        public Ladrillo[,] Ladrillos
        {
            get
            {
                return ladrillos;
            }
            set
            {
                ladrillos = value;
            }
        }

        public Pala Pala
        {
            get
            {
                return pala;
            }
            set
            {
                pala = value;
            }
        }

        public Pelota Pelota
        {
            get 
            {
                return pelota;
            }
            set 
            {
                pelota = value;
            }
        }
        

        /// <summary>
        /// El tablero inicializa los ladrillos, la pala y la pelota.
        /// </summary>
        public Tablero()
        {
            this.estado = Estado.INICIO;

            initLadrillos();
            
            pala = 
                new Pala(Constantes.POSICION_X_PALA, 
                         Constantes.POSICION_Y_PALA);
            
            pelota = 
                new Pelota(Constantes.POSICION_X_PELOTA, 
                           Constantes.POSICION_Y_PELOTA);
        }


        private void initLadrillos() 
        {
            ladrillos =
                new Ladrillo[
                    Constantes.NUMERO_FILAS_LADRILLOS,
                    Constantes.NUMERO_COLUMNAS_LADRILLOS
                ];


            // inicializa los ladrillos con sus respectivas posiciones.
            int posX = 21, posY = 2;
            for (int fila = 0; fila < Constantes.NUMERO_FILAS_LADRILLOS; fila++)
            {
                for (int columna = 0; columna < Constantes.NUMERO_COLUMNAS_LADRILLOS; columna++)
                {
                    Ladrillo ladrillo = new Ladrillo(posX, posY);
                    ladrillos[fila, columna] = ladrillo;
                    posX += 3;
                }
                posX = 21;
                posY++;
            }
        }


        public void Dibujar() 
        {
            int posX = 20, posY = 0;

            // Muro vertical del tablero situado a la izquierda
            for (int i = posY; i < 25; i++) {
                Console.SetCursorPosition(posX, i);
                Console.Write("|");
            }


            posX = 60; 

            // Muro vertical del tablero situado a la derecha
            for (int i = posY; i < 25; i++)
            {
                Console.SetCursorPosition(posX, i);
                Console.Write("|");
            }


            posX = 21;

            // Muro superior del tablero
            posY = 0;
            for (int i = posX; i < 60; i++)
            {
                Console.SetCursorPosition(i, posY);
                Console.Write("*");
            }


            for (int fila = 0; fila < Constantes.NUMERO_FILAS_LADRILLOS; fila++)
            {
                for (int columna = 0; columna < Constantes.NUMERO_COLUMNAS_LADRILLOS; columna++)
                {

                    ladrillos[fila, columna].Dibujar();
                }
            }

            pala.Dibujar();
            pelota.Dibujar();
        }


        public void Mover() 
        {
            pelota.Mover();   
        }


        public void ComprobarColisiones() 
        {
            // Comprueba si la pelota colisiona con la pala.
            if (pelota.GetPosX() >= pala.GetX() &&
                pelota.GetPosX() <= pala.GetX() + Constantes.TAMAÑO_PALA &&
                pelota.GetPosY().Equals(pala.GetY()-1))
            {
                pelota.RebotarInversa();
            }


            // Comprueba si la pelota colisiona con algún ladrillo.
            bool hayColision = false;
            for (int fila = 0; fila < Constantes.NUMERO_FILAS_LADRILLOS; fila++)
            {
                for (int columna = 0; columna < Constantes.NUMERO_COLUMNAS_LADRILLOS; columna++)
                {
                    if (ladrillos[fila, columna].IsVisible())
                    {
                        if (pelota.GetPosY().Equals(ladrillos[fila, columna].GetY())&&
                            pelota.GetPosX() >= ladrillos[fila, columna].GetX() &&
                            pelota.GetPosX() <= ladrillos[fila, columna].GetX()+ Constantes.TAMAÑO_LADRILLO)
                        {
                            ladrillos[fila, columna].SetVisible(false);

                            hayColision = true;
                        }
                    }

                    if (hayColision) {
                        break;
                    }
                }

                if (hayColision){
                    break;
                }
            }

            if (hayColision)
            {
                pelota.Rebotar();
            }


            

        }


        public void Limpiar() 
        {
            Console.Clear();
        }

        public void Pausar()
        {
            Thread.Sleep(40);
        }

        public void ControlTeclas() {

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.P:
                        this.estado = Estado.PAUSADO;
                        break;

                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Escape:
                        this.estado = Estado.JUGANDO;

                        break;

                    case ConsoleKey.LeftArrow:
                        if (this.estado.Equals(Estado.PAUSADO))
                            return;

                        if (this.estado.Equals(Estado.INICIO))
                        {
                            if (pala.GetPosX() > 21)
                            {
                                pala.Mover(pala.GetPosX() - 1, pala.GetY());
                                pelota.Mover(pelota.GetPosX() - 1, pelota.GetPosY());
                            }
                        }

                        if (this.estado.Equals(Estado.JUGANDO))
                        {
                            if (pala.GetPosX() > 21)
                            {
                                pala.Mover(pala.GetPosX() - 1, pala.GetY());
                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (this.estado.Equals(Estado.PAUSADO))
                            return;

                        if (this.estado.Equals(Estado.INICIO))
                        {
                            if (pala.GetPosX() < 55)
                            {
                                pala.Mover(pala.GetPosX() + 1, pala.GetY());
                                pelota.Mover(pelota.GetPosX() + 1, pelota.GetPosY());
                            }
                        }

                        if (this.estado.Equals(Estado.JUGANDO))
                        {
                            if (pala.GetPosX() < 55)
                            {
                                pala.Mover(pala.GetPosX() + 1, pala.GetY());
                            }
                        }
                        break;

                }
            }
        }


        public void Actualizar() 
        {
            switch (this.estado) 
            {
                case Estado.INICIO:
                case Estado.PAUSADO:
                    Dibujar();
                    ControlTeclas();
                    Pausar();
                    Limpiar();

                    break;

                case Estado.JUGANDO:

                    Dibujar();
                    Mover();
                    ControlTeclas();
                    ComprobarColisiones();
                    Pausar();
                    Limpiar();

                    break;

                case Estado.GANADOR:
                    break;

                case Estado.PERDEDOR:
                    break;

                case Estado.FIN:
                    break;
            }
        }
    }
}
