using System;

namespace Desafio_1_Totito
{
    internal class Program
    {
        static int[,] tabla;
        static char[] simbolos = { '.', 'X', 'O' };
        static char jugadorActual = 'X';
        static bool Ganador;

        static void Main(string[] args)
        {
            Console.WriteLine("JUEGO DE TOTITO");
            Console.WriteLine(" X O ");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();

            tabla = new int[3, 3];

            while (!Ganador)
            {
                pantalla();
                usuario(jugadorActual);
                Comprobar();
                moverXO();
                Pausa();
            }
        }

        private static void Pausa()
        {
            Console.ReadKey();
        }

        private static void Comprobar()
        {
            Ganador = false;

            for (int fila = 0; fila < 3; fila++)
            {
                if (tabla[fila, 0] == tabla[fila, 1] &&
                    tabla[fila, 0] == tabla[fila, 2] &&
                    tabla[fila, 0] != 0)
                {
                    Ganador = true;
                    Console.WriteLine($"{simbolos[tabla[fila, 0]]} GANADOR!");
                    return;
                }
            }

            for (int columna = 0; columna < 3; columna++)
            {
                if (tabla[0, columna] == tabla[1, columna] &&
                    tabla[0, columna] == tabla[2, columna] &&
                    tabla[0, columna] != 0)
                {
                    Ganador = true;
                    Console.WriteLine($"{simbolos[tabla[0, columna]]}GANADOR!");
                    return;
                }
            }

            // Verificar diagonal principal
            if (tabla[0, 0] == tabla[1, 1] &&
                tabla[0, 0] == tabla[2, 2] &&
                tabla[0, 0] != 0)
            {
                Ganador = true;
                Console.WriteLine($"{simbolos[tabla[0, 0]]} GANADOR!");
                return;
            }

            // Verificar diagonal secundaria
            if (tabla[0, 2] == tabla[1, 1] &&
                tabla[0, 2] == tabla[2, 0] &&
                tabla[0, 2] != 0)
            {
                Ganador = true;
                Console.WriteLine($"¡{simbolos[tabla[0, 2]]} GANADOR!");
                return;
            }
        }

        private static void moverXO()
        {
            jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
        }

        private static void usuario(char jugador)
        {
            Console.Write("Ingresa la fila deseada (1-3): ");
            int fila = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Ingresa la columna deseada (1-3): ");
            int columna = Convert.ToInt32(Console.ReadLine()) - 1;

            tabla[fila, columna] = (jugador == 'X') ? 1 : 2;
        }

        private static void pantalla()
        {
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(simbolos[tabla[fila, columna]]);
                }
                Console.WriteLine();
            }
        }
    }
}
