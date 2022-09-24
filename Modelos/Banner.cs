using System;

namespace Jarkanoid
{
    class Banner
    {
        public static void Escribir(string txt)
        {
            string Entry = txt;

            byte j = 1;
            char Letra;
            int[] CodigoAscii = new int[Entry.Length];

            //Convierto la cadena en enteros 
            for (int i = 0; i < Entry.Length; i++)
            {
                Letra = Convert.ToChar(Entry.Substring(i, j));
                CodigoAscii[i] = Convert.ToInt32(Letra);
            }

            int AnchoLetras = 7, AltoLetra = 7;
            int numeroAscii = 32;
            int countLineas = 0, countLetras = 0, countPosiciones = 0;
            bool LetraEncontrada = false;
            string[] cadena = new string[AltoLetra];

            // Recorro todas las letras
            for (int i = 0; i < CodigoAscii.Length; i++)
            {
                // Recorro todos las filas del esqueleto de letras
                for (int row = 0; row < esqueleto.Length; row++)
                {
                    if (countLetras == 8)
                    {
                        row += AltoLetra - 1;
                        countLetras = 0;
                        countPosiciones = 0;
                    }
                    //Si no la encuentro tengo que ir aumento la posicion y el numero ascii 
                    while ((!LetraEncontrada) && (countLetras < 8))
                    {
                        if (CodigoAscii[i] == numeroAscii)
                            LetraEncontrada = true;
                        else
                        {
                            numeroAscii++;
                            countPosiciones += AnchoLetras;
                            countLetras++;
                        }
                    }
                    //Si la e encontrado y no tengo las 7 lineas de la letra
                    if ((LetraEncontrada) && (countLineas < 7))
                    {
                        if (i > 0)
                            cadena[countLineas] = cadena[countLineas] + esqueleto[row].Substring(countPosiciones, AnchoLetras);
                        else
                            cadena[countLineas] = esqueleto[row].Substring(countPosiciones, AnchoLetras);
                        countLineas++;
                    }
                }
                countLineas = 0;
                numeroAscii = 32;
                LetraEncontrada = false;
                countPosiciones = 0;
                countLetras = 0;
            }

            //Muestro
              for (int i = 0; i < cadena.Length; i++)
            {

                Console.WriteLine(cadena[i]);
            }
        }

        static string[] esqueleto =  {  
            "         OOO  OOO OOO  O O   OOOOO OOO   O  OO     OOO  ", 
            "         OOO  OOO OOO  O O  O  O  OO O  O  O  O    OOO  ", 
            "         OOO   O   O OOOOOOOO  O   OOO O    OO      O   ", 
            "          O            O O   OOOOO    O    OOO     O    ", 
            "                     OOOOOOO   O  O  O OOOO   O O       ", 
            "         OOO           O O  O  O  O O  O OO    O        ", 
            "         OOO           O O   OOOOO O   OOO OOOO O       ", 
            "   OO    OO                                            O", 
            "  O        O   O   O    O                             O ", 
            " O          O   O O     O                            O  ", 
            " O          O OOOOOOO OOOOO   OOO   OOOOO           O   ", 
            " O          O   O O     O     OOO           OOO    O    ", 
            "  O        O   O   O    O      O            OOO   O     ", 
            "   OO    OO                   O             OOO  O      ", 
            "  OOO     O    OOOOO  OOOOO O      OOOOOOO OOOOO OOOOOOO", 
            " O   O   OO   O     OO     OO    O O      O     OO    O ", 
            "O     O O O         O      OO    O O      O          O  ", 
            "O     O   O    OOOOO  OOOOO O    O OOOOOO OOOOOO    O   ", 
            "O     O   O   O            OOOOOOOO      OO     O  O    ", 
            " O   O    O   O      O     O     O O     OO     O  O    ", 
            "  OOO   OOOOO OOOOOOO OOOOO      O  OOOOO  OOOOO   O    ", 
            " OOOOO  OOOOO    O     OOO      O           O     OOOOO ", 
            "O     OO     O  OOO    OOO     O             O   O     O", 
            "O     OO     O   O            O     OOOOO     O        O", 
            " OOOOO  OOOOOO         OOO   O                 O     OO ", 
            "O     O      O   O     OOO    O     OOOOO     O     O   ", 
            "O     OO     O  OOO     O      O             O          ", 
            " OOOOO  OOOOO    O     O        O           O       O   ", 
            " OOOOO    O   OOOOOO  OOOOO OOOOOO OOOOOOOOOOOOOO OOOOO ", 
            "O     O  O O  O     OO     OO     OO      O      O     O", 
            "O OOO O O   O O     OO      O     OO      O      O      ", 
            "O O O OO     OOOOOOO O      O     OOOOOO  OOOOO  O  OOOO", 
            "O OOOO OOOOOOOO     OO      O     OO      O      O     O", 
            "O      O     OO     OO     OO     OO      O      O     O", 
            " OOOOO O     OOOOOOO  OOOOO OOOOOO OOOOOOOO       OOOOO ", 
            "O     O  OOO        OO    O O      O     OO     OOOOOOOO", 
            "O     O   O         OO   O  O      OO   OOOO    OO     O", 
            "O     O   O         OO  O   O      O O O OO O   OO     O", 
            "OOOOOOO   O         OOOO    O      O  O  OO  O  OO     O", 
            "O     O   O   O     OO  O   O      O     OO   O OO     O", 
            "O     O   O   O     OO   O  O      O     OO    OOO     O", 
            "O     O  OOO   OOOOO O    O OOOOOOOO     OO     OOOOOOOO", 
            "OOOOOO  OOOOO OOOOOO  OOOOO OOOOOOOO     OO     OO     O", 
            "O     OO     OO     OO     O   O   O     OO     OO  O  O", 
            "O     OO     OO     OO         O   O     OO     OO  O  O", 
            "OOOOOO O     OOOOOOO  OOOOO    O   O     OO     OO  O  O", 
            "O      O   O OO   O        O   O   O     O O   O O  O  O", 
            "O      O    O O    O O     O   O   O     O  O O  O  O  O", 
            "O       OOOO OO     O OOOOO    O    OOOOO    O    OO OO ", 
            "O     OO     OOOOOOOO OOOOO O       OOOOO    O          ", 
            " O   O  O   O      O  O      O          O   O O         ", 
            "  O O    O O      O   O       O         O  O   O        ", 
            "   O      O      O    O        O        O               ", 
            "  O O     O     O     O         O       O               ", 
            " O   O    O    O      O          O      O               ", 
            "O     O   O   OOOOOOO OOOOO       O OOOOO        OOOOOOO", 
            "  OOO                                                   ", 
            "  OOO     OO   OOOOO   OOOO  OOOOO  OOOOOO OOOOOO  OOOO ", 
            "   O     O  O  O    O O    O O    O O      O      O    O", 
            "        OOOOOO O    O O      O    O O      O      O  OOO", 
            "    O   O    O OOOOO  O      O    O OOOOO  OOOOO  O     ", 
            "        O    O O    O O    O O    O O      O      O    O", 
            "        O    O OOOOO   OOOO  OOOOO  OOOOOO O       OOOO ", 
            "                                                        ", 
            " O    O    O        O O    O O      O    O O    O  OOOO ", 
            " O    O    O        O O   O  O      OO  OO OO   O O    O", 
            " OOOOOO    O        O OOOO   O      O OO O O O  O O    O", 
            " O    O    O        O O  O   O      O    O O  O O O    O", 
            " O    O    O   O    O O   O  O      O    O O   OO O    O", 
            " O    O    O    OOOO  O    O OOOOOO O    O O    O  OOOO ", 
            "                                                        ", 
            " OOOOO   OOOO  OOOOO   OOOO   OOOOO O    O O    O O    O", 
            " O    O O    O O    O O         O   O    O O    O O    O", 
            " O    O O    O O    O  OOOO     O   O    O O    O O    O", 
            " OOOOO  O  O O OOOOO       O    O   O    O O    O O OO O", 
            " O      O   O  O   O  O    O    O   O    O  O  O  OO  OO", 
            " O       OOO O O    O  OOOO     O    OOOO    OO   O    O", 
            "                       OOO     O     OOO   OO    O O O O", 
            " O    O  O   O OOOOOO O        O        O O  O  O O O O ", 
            "  O  O    O O      O  O        O        O     OO O O O O", 
            "   OO      O      O  OO                 OO        O O O ", 
            "   OO      O     O    O        O        O        O O O O", 
            "  O  O     O    O     O        O        O         O O O ", 
            " O    O    O   OOOOOO  OOO     O     OOO         O O O O"
                                     };

    }
}
