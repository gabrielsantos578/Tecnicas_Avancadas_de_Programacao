/******************************************************************************

                        List of Exercises - Matrix

 Ex 5 º - Faça um programa que faça a soma de duas matrizes. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int col, lin;
        Console.Write("Matrizes - Quant. Colunas: ");
        col = Convert.ToInt32(Console.ReadLine());
        Console.Write("Matrizes - Quant. Linhas: ");
        lin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); Console.WriteLine();

        double[,] matriz1 = new double[lin, col];
        double[,] matriz2 = new double[lin, col];
        double[,] matrizS = new double[lin, col];

        Random numero = new Random();

        Console.WriteLine("----  Matriz 1  ----"); Console.WriteLine();
        for (int c = 0; c < lin; c++)
        {
            for (int l = 0; l < col; l++)
            {
                matriz1[c, l] = numero.Next(99);
                if (matriz1[c, l] < 10)
                {
                    Console.Write(" " + matriz1[c, l] + " ");
                }
                else
                {
                    Console.Write(matriz1[c, l] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("----  Matriz 2  ----"); Console.WriteLine();
        for (int c = 0; c < lin; c++)
        {
            for (int l = 0; l < col; l++)
            {
                matriz2[c, l] = numero.Next(99);
                if (matriz2[c, l] < 10)
                {
                    Console.Write(" " + matriz2[c, l] + " ");
                }
                else
                {
                    Console.Write(matriz2[c, l] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("------  Soma  ------"); Console.WriteLine();
        for (int c = 0; c < lin; c++)
        {
            for (int l = 0; l < col; l++)
            {
                matrizS[c, l] = matriz1[c, l] + matriz2[c, l];
                if (matrizS[c, l] < 10)
                {
                    Console.Write("  " + matrizS[c, l] + " ");
                }
                else if (matrizS[c, l] < 100)
                {
                    Console.Write(" " + matrizS[c, l] + " ");
                }
                else
                {
                    Console.Write(matrizS[c, l] + " ");
                }
            }
            Console.WriteLine();
        }

    }

}