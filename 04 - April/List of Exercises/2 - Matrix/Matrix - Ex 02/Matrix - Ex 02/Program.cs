/******************************************************************************

                        List of Exercises - Matrix

 Ex 2 º - Faça  um  algoritmo  que  construa  uma  matriz  50  por  50  de  
números  reais  e  depois  de  construída, colocar  o  conteúdo  de  sua  
diagonal  principal  dentro  de  um  vetor  e  depois  do  vetor  montado, 
imprimir o vetor. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        double[,] matriz = new double[50, 50];
        double[] vetor = new double[50];

        Random numero = new Random();

        for (int c = 0; c < 50; c++)
        {
            for (int l = 0; l < 50; l++)
            {
                matriz[l, c] = numero.Next(999);
            }
        }

        for (int i = 0; i < 50; i++)
        {
            vetor[i] = matriz[i, i];
        }

        Console.WriteLine();
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Matriz [" + i + ", " + i + "]: " + vetor[i]);
        }

    }

}