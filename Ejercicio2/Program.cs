using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 0; int C = 0; int SUMP = 0; int SUMS = 0; int sumadiagonales = 0;
            // INGRESO 
            // PARA COMODIDAD GENERAMOS VALORES PARA LA MATRIZ 
            Random aleatorio = new Random();
            int[,] MAT = new int[5 + 1, 5 + 1]; for (F = 1; F <= 5; F++)

            {
                for (C = 1; C <= 5; C++)
                {
                    MAT[F, C] = aleatorio.Next(0, 100);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            // DIAGONAL  PRINCIPAL             
            SUMP = 0;
            for (F = 1; F <= 5; F++)
            {
                SUMP = SUMP + MAT[F, F];
            }
            // DIAGONAL SECUNDARIA 

            SUMS = 0;
            C = 5;
            for (F = 1; F <= 5; F++)
            {
                SUMS = SUMS + MAT[F, C];
                C = C - 1;
                
            }
            {
                sumadiagonales= SUMP + SUMS;    
            }
            // SALIDA 
            Console.WriteLine();
            Console.WriteLine("SUMA DIAGONAL PRINCIPAL ES: " + SUMP);
            Console.WriteLine("SUMA DIAGONAL SECUNDARIA ES: " + SUMS);
            Console.WriteLine("SUMA DE LAS DIAGONALES ES: " + sumadiagonales);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}