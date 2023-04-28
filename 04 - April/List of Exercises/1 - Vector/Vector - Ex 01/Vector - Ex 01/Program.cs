/******************************************************************************

                        List of Exercises - Vector

 Ex 1 º - Faça  um  programa  que  lê  10  números  inteiros  do  teclado  e  
armazene  em  um  vetor.  Ao  final imprima o vetor armazenado nos dois sentidos. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int[] vetor = new int[10];

        Random numero = new Random();

        for (int i = 0; i < 10; i++)
        {
            vetor[i] = numero.Next(99);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Vetor[" + i + "]: " + vetor[i]);
        }
        Console.WriteLine();

        for (int i = 9; i > -1; i--)
        {
            Console.WriteLine("Vetor[" + i + "]: " + vetor[i]);
        }

    }

}