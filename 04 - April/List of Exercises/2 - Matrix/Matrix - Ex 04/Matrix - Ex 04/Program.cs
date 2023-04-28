/******************************************************************************

                        List of Exercises - Matrix

 Ex 4 º - Faça um programa que faça a multiplicação de duas matrizes. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int c1, l1, c2, l2;
        Console.Write("Matriz 1 - Quant. Colunas: ");
        c1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Matriz 1 - Quant. Linhas: ");
        l1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Matriz 2 - Quant. Colunas: ");
        c2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Matriz 2 - Quant. Linhas: ");
        l2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); Console.WriteLine();

        double[,] matriz1 = new double[l1, c1];
        double[,] matriz2 = new double[l2, c2];
        double[] vetor1 = new double[l1];
        double[] vetor2 = new double[c2];
        double[,] matrizM = new double[l1, c2];

        Random numero = new Random();

        Console.WriteLine("----  Matriz 1  ----"); Console.WriteLine();
        for (int c = 0; c < l1; c++)
        {
            for (int l = 0; l < c1; l++)
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

        for (int c = 0; c < l1; c++)
        {

            vetor1[c] = 0;

            for (int l = 0; l < c1; l++)
            {

                vetor1[c] += matriz1[c, l];

            }

        }



        Console.WriteLine("----  Matriz 2  ----"); Console.WriteLine();
        for (int c = 0; c < l2; c++)
        {
            for (int l = 0; l < c2; l++)
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

        for (int c = 0; c < c2; c++)
        {

            vetor2[c] = 0;

            for (int l = 0; l < l2; l++)
            {

                vetor2[c] += matriz2[l, c];

            }

        }


        Console.WriteLine("--  Multiplicação  --"); Console.WriteLine();
        for (int c = 0; c < l1; c++)
        {
            for (int l = 0; l < c2; l++)
            {
                matrizM[c, l] = vetor1[c] * vetor2[l];
                if (matrizM[c, l] < 10000)
                {
                    Console.Write("  " + matrizM[c, l] + " ");
                }
                else if (matrizM[c, l] < 100000)
                {
                    Console.Write(" " + matrizM[c, l] + " ");
                }
                else
                {
                    Console.Write(matrizM[c, l] + " ");
                }
            }
            Console.WriteLine();
        }

    }

}