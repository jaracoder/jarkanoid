
namespace Jarkanoid
{
    class Partida
    {
        protected Tablero tablero;

   
        public void NuevaPartida()
        {
            bool PartidaAcabada = false;

            tablero = new Tablero();

            do
            {
                tablero.Actualizar();
                //tablero.Dibujar();
                //tablero.Mover();

               
                
                //tablero.ControlTeclas();
                //tablero.ComprobarColisiones();

                //tablero.Pausar();
                //tablero.Limpiar();

            }
            while (!PartidaAcabada);
        }
    }
}
