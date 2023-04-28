/******************************************************************************

                        List of Exercises - Vector

 Ex 6 º - Utilizando  vetores,  crie um  programa  que  organize  uma  
quantidade  qualquer  de  números  inteiros fornecidos  pelo  usuário  da  
seguinte  forma:  primeiro  os  números  pares  em  ordem  crescente  e depois 
os números ímpares em ordem decrescente.   

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int[] vetorPar = new int[10];
        int[] vetorImpar = new int[10];

        int p = 0, i = 0;
        for (int inte = 0; inte < 10; inte++)
        {

            Console.Write("Escreva um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {

                vetorPar[p++] = num;

            }
            else
            {

                vetorImpar[i++] = num;

            }

        }
        Console.WriteLine();

        for (int inte = 0; inte < (p - 1); inte++)
        {

            if (vetorPar[inte] > vetorPar[inte + 1])
            {

                int aux = vetorPar[inte];
                vetorPar[inte] = vetorPar[inte + 1];
                vetorPar[inte + 1] = aux;

                inte = -1;

            }

        }

        for (int inte = 0; inte < (i - 1); inte++)
        {

            if (vetorImpar[inte] < vetorImpar[inte + 1])
            {

                int aux = vetorImpar[inte];
                vetorImpar[inte] = vetorImpar[inte + 1];
                vetorImpar[inte + 1] = aux;

                inte = -1;

            }

        }

        for (int inte = 0; inte < p; inte++)
        {

            Console.WriteLine("Vetor Par [" + inte + "]: " + vetorPar[inte]);

        }
        Console.WriteLine();

        for (int inte = (i - 1); inte > -1; inte--)
        {

            Console.WriteLine("Vetor Ímpar [" + inte + "]: " + vetorImpar[inte]);

        }

    }

}