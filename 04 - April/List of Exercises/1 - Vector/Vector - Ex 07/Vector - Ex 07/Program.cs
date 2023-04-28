/******************************************************************************

                        List of Exercises - Vector

 Ex 7 º - Dados  dois  vetores  de  tamanho  N,  faça  uma  função  que  diga  
se  os  mesmos  possuam  conteúdo igual. 

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        Console.Write("Informe o tamanho dos vetores: ");
        int T = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int[] vetor1 = new int[T];
        int[] vetor2 = new int[T];

        Random numero = new Random();

        for (int i = 0; i < T; i++)
        {
            Console.Write("Vetor 1 [" + i + "]: ");
            vetor1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < T; i++)
        {
            Console.Write("Vetor 1 [" + i + "]: ");
            vetor2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();

        comparacaoVetor(vetor1, vetor2, T);

    }

    public static int comparacaoVetor(int[] v1, int[] v2, int T)
    {

        int comp = 0;
        for (int i = 0; i < T; i++)
        {

            if (v1[i] != v2[i])
            {
                comp = 1;
            }

        }

        if (comp == 0)
        {
            Console.WriteLine("Os vetores possuem conteúdos iguais.");

        }
        else
        {
            Console.WriteLine("Os vetores possuem conteúdos diferentes.");

        }

        return 0;

    }

}