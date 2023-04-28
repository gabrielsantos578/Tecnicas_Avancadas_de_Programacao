/******************************************************************************

                        List of Exercises - Vector

 Ex 5 º - Faça um programa que leia e monte dois vetores de números inteiros 
com 20 números cada. Depois de montados gere um terceiro vetor formado pela 
diferença dos dois vetores lidos, um quarto vetor formado pela soma dos dois 
vetores lidos e por último um quinto vetor formado pela multiplicação dos dois 
vetores lidos.  

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int[] vetor1 = new int[20];
        int[] vetor2 = new int[20];
        int[] vetor3 = new int[20];
        int[] vetor4 = new int[20];
        int[] vetor5 = new int[20];

        Random numero = new Random();

        for (int i = 0; i < 20; i++)
        {

            vetor1[i] = numero.Next(99);
            vetor2[i] = numero.Next(99);
            vetor3[i] = vetor1[i] - vetor2[i];
            vetor4[i] = vetor1[i] + vetor2[i];
            vetor5[i] = vetor1[i] * vetor2[i];

        }
        Console.WriteLine();

        for (int i = 0; i < 20; i++)
        {

            Console.WriteLine("Vetor 1 [" + i + "]: " + vetor1[i]);
            Console.WriteLine("Vetor 2 [" + i + "]: " + vetor2[i]);
            Console.WriteLine("Vetor 3 [" + i + "]: " + vetor3[i]);
            Console.WriteLine("Vetor 4 [" + i + "]: " + vetor4[i]);
            Console.WriteLine("Vetor 5 [" + i + "]: " + vetor5[i]);
            Console.WriteLine();

        }

    }

}