using System;

namespace Jarkanoid
{
    class Ladrillo : ElementoGrafico
    {
        public Ladrillo(int x, int y)
        {
            this.posX = x;
            this.posY = y;
            visible = true;
            elemento = "[O]";
        }

        public void Dibujar(int x, int y) 
        {
            if (visible) 
            {
                Console.SetCursorPosition(x, y);
                Console.Write(elemento);
            }
        }

        public int GetX()
        {
            return posX;
        }

        public int GetY()
        {
            return posY;
        }

        public void RomperLadrillo(int x, int y)
        {
            if ((posX >= x) && (posX <= (x + elemento.Length)) 
                && (posY == y) && (visible))
                visible = false;
        }
    }
}
