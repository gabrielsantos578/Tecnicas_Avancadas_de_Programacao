/******************************************************************************

                        List of Exercises - Vector

 Ex 2 º - Ler um vetor de 10 elementos. Crie um segundo vetor, com todos os 
elementos na ordem inversa, ou seja, o último elemento passará a ser o primeiro, 
o penúltimo será o segundo e assim por diante. Imprima os dois vetores.

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];

        Random numero = new Random();

        for (int i = 0; i < 10; i++)
        {
            vetor1[i] = numero.Next(99);
        }

        for (int i = 0; i < 10; i++)
        {
            vetor2[i] = vetor1[(9 - i)];
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Vetor1[" + i + "]: " + vetor1[i]);
            Console.WriteLine("Vetor2[" + i + "]: " + vetor2[i]);
        }

    }

}