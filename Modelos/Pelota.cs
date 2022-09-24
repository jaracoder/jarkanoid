
namespace Jarkanoid
{
    class Pelota : ElementoGrafico
    {
        private int avanceX, avanceY;

        public Pelota(int x, int y)
        {
            this.posX = x;
            this.posY = y;
            avanceX = 1;
            avanceY = -1;
            elemento = ".";
            visible = true;
        }

        public void Rebotar()
        {
            avanceX = -avanceX;
            avanceY = -avanceY;
        }

        public void RebotarInversa()
        {
            avanceY = -avanceY;
        }

        public void DetectarColisionesFondo()
        {
            if (posX < 22)
                avanceX = -avanceX;
            if (posX > 58)
                avanceX = -avanceX;
            if (posY < 2)
                avanceY = -avanceY;
            if (posY >23)
                avanceY = -avanceY;

        }

        public void Mover()
        {
            DetectarColisionesFondo();
            posX += avanceX;
            posY += avanceY;
        }
    }
}
