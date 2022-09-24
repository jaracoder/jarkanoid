
namespace Jarkanoid
{
    class Nivel
    {
        protected Ladrillo[,] bloques;
        protected int numero;


        public Nivel(int numero)
        {
            this.numero = numero;
        }


        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
    }
}
