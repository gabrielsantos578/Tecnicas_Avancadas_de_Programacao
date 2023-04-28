/******************************************************************************

                        List of Exercises - Matrix

 Ex 1 º - Faça  um  algoritmo  que  construa  uma  matriz  de  nome  MAT  de  
10  linhas  e  15  colunas  contendo números  inteiros.  Em  seguida  escreva  
a  soma  dos  elementos  de  cada  linha  e  se  a  soma  dos elementos é par 
ou impar. Por fim escreva a soma dos elementos de cada coluna e se a soma dos 
elementos é par ou impar. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int[,] matriz = new int[10, 15];
        int[,] matrizSoma = new int[2, 15];

        matrizSoma[0, 0] = 0; matrizSoma[1, 0] = 0;

        Random numero = new Random();

        for (int c = 0; c < 15; c++)
        {
            for (int l = 0; l < 10; l++)
            {
                matriz[l, c] = numero.Next(999);
                matrizSoma[0, l] += matriz[l, c];
                matrizSoma[1, c] += matriz[l, c];
            }
        }

        Console.WriteLine("----------  LINHAS  ----------"); Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {

            if (matrizSoma[0, i] % 2 == 0)
            {
                Console.WriteLine("Matriz Linha[" + i + "]: " + matrizSoma[0, i] + " (PAR)");
            }
            else
            {
                Console.WriteLine("Matriz Linha[" + i + "]: " + matrizSoma[0, i] + " (ÍMPAR)");
            }

        }
        Console.WriteLine(); Console.WriteLine();

        Console.WriteLine("----------  COLUNAS  ----------"); Console.WriteLine();
        for (int i = 0; i < 15; i++)
        {

            if (matrizSoma[1, i] % 2 == 0)
            {
                Console.WriteLine("Matriz Coluna[" + i + "]: " + matrizSoma[1, i] + " (PAR)");
            }
            else
            {
                Console.WriteLine("Matriz Coluna[" + i + "]: " + matrizSoma[1, i] + " (ÍMPAR)");
            }

        }

    }

}