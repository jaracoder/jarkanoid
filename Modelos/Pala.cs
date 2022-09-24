using System;

namespace Jarkanoid
{
    class Pala : ElementoGrafico
    {
        private ConsoleKeyInfo cki;

        public Pala(int x, int y)
        {
            posX = x;
            posY = y;
            elemento = "-----";
            visible = true;
        }

        public void Mover() 
        {
            if (cki.Key == ConsoleKey.RightArrow)
                posX++;
            if (cki.Key == ConsoleKey.LeftArrow)
                posX--;
        }

        public int GetX()
        {
            return posX;
        }

        public int GetY()
        {
            return posY;
        }
    }
}
