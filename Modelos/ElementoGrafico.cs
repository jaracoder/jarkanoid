using System;

namespace Jarkanoid
{
    class ElementoGrafico
    {
        protected int posX;
        protected int posY;
        protected string elemento;
        protected bool visible;

        public void Dibujar()
        {
            if (visible)
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(elemento);
            }
        }

        public void Mover(int x, int y)
        {
            posX = x;
            posY = y;
        }

        public void SetPosX(int newPosX)
        {
            posX = newPosX;
        }

        public int GetPosX()
        {
            return posX;
        }

        public void SetPosY(int newPosY)
        {
            posY = newPosY;
        }

        public int GetPosY()
        {
            return posY;
        }

        public void SetVisible(bool isVisible)
        {
            visible = isVisible;
        }

        public bool IsVisible()
        {
            return visible;
        }

    }
}
