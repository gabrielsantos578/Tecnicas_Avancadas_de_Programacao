/******************************************************************************

                        List of Exercises - Matrix

 Ex 3 º - Faça  um  programa  que  gere  uma  matriz  transposta  (Matriz  
transposta  é  toda  a  matriz  onde  são trocadas as linhas pelas colunas, ou 
vice-versa). 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        double[,] matriz = new double[5, 5];
        double[,] matrizT = new double[5, 5];

        Random numero = new Random();

        for (int c = 0; c < 5; c++)
        {
            for (int l = 0; l < 5; l++)
            {
                matriz[l, c] = numero.Next(999);
                matrizT[c, l] = matriz[l, c];
            }
        }
        Console.WriteLine();

        for (int l = 0; l < 5; l++)
        {
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Matriz [" + l + ", " + c + "]: " + matriz[l, c]);
            }
        }
        Console.WriteLine();

        for (int l = 0; l < 5; l++)
        {
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Matriz Transposta [" + l + ", " + c + "]: " + matrizT[l, c]);
            }
        }

    }

}