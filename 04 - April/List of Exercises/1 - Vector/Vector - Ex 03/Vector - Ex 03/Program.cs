/******************************************************************************

                        List of Exercises - Vector

 Ex 3 º - Ler  um  vetor  de  10  elementos  inteiros  e  positivos. Criar  um  
segundo  vetor  da  seguinte  forma:  os elementos de índice par receberão os 
respectivos elementos divididos por 2; os elementos de índice ímpar receberão os 
respectivos elementos multiplicados por 3. Imprima os dois vetores. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        double[] vetor = new double[10];

        Random numero = new Random();

        for (int i = 0; i < 10; i++)
        {

            int num = (numero.Next(99) - 70);

            if (num > -1)
            {

                if (i % 2 == 0)
                {
                    vetor[i] = Convert.ToDouble(num) / 2;

                }
                else
                {
                    vetor[i] = num * 3;

                }

            }
            else
            {
                i--;

            }

        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Vetor[" + i + "]: " + vetor[i]);
        }

    }

}