/******************************************************************************

                        List of Exercises - Matrix

 Ex 6 º - Faça um programa que deverá permitir que o usuário entre com os 
valores dos elementos de uma matriz quadrada de ordem 4 e possibilite o usuário 
realizar as seguintes funcionalidades:  

    a)Imprimir todos os elementos da matriz;  
    b)Somar os quadrados de todos os elementos da primeira coluna;   
    c)Somar todos os elementos da terceira linha;   
    d)Somar os elementos da diagonal principal; e  
    e)Somar todos os elementos de índice par da segunda linha.  

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        double[,] matriz = new double[4, 4];

        Console.WriteLine();
        Console.WriteLine("-----  Matriz  -----"); Console.WriteLine();
        for (int c = 0; c < 4; c++)
        {
            for (int l = 0; l < 4; l++)
            {
                Console.Write("Matriz [" + c + ", " + l + "]: ");
                matriz[c, l] = Convert.ToDouble(Console.ReadLine());
            }
        }
        Console.WriteLine(); Console.WriteLine();


        int opcao = 1, tolerancia = 0;

        while (opcao != 0)
        {

            Console.WriteLine("------  Menu  ------"); Console.WriteLine();
            Console.WriteLine("[1] Imprimir elementos da matriz");
            Console.WriteLine("[2] Somar os elementos da primeira coluna");
            Console.WriteLine("[3] Somar todos os elementos da terceira linha");
            Console.WriteLine("[4] Somar os elementos da diagonal principal");
            Console.WriteLine("[5] Somar os elementos de índice par da segunda linha");
            Console.WriteLine("[0] Encerrar programa"); Console.WriteLine();
            Console.Write("Digite a opção: "); opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (opcao == 1)
            {

                Console.WriteLine("-----  Matriz  -----"); Console.WriteLine();

                for (int c = 0; c < 4; c++)
                {
                    for (int l = 0; l < 4; l++)
                    {
                        Console.Write(matriz[c, l] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(); Console.WriteLine();

            }
            else if (opcao == 2)
            {

                double soma = 0;

                for (int c = 0; c < 4; c++)
                {
                    soma += matriz[c, 0];
                }
                Console.WriteLine();

                Console.WriteLine("Soma: " + soma);
                Console.WriteLine(); Console.WriteLine();

            }
            else if (opcao == 3)
            {

                double soma = 0;

                for (int l = 0; l < 4; l++)
                {
                    soma += matriz[2, l];
                }
                Console.WriteLine();

                Console.WriteLine("Soma: " + soma);
                Console.WriteLine(); Console.WriteLine();

            }
            else if (opcao == 4)
            {

                double soma = 0;

                for (int l = 0; l < 4; l++)
                {
                    soma += matriz[l, l];
                }
                Console.WriteLine();

                Console.WriteLine("Soma: " + soma);
                Console.WriteLine(); Console.WriteLine();

            }
            else if (opcao == 5)
            {

                double soma = 0;

                for (int l = 0; l < 4; l += 2)
                {
                    soma += matriz[1, l];
                }
                Console.WriteLine();

                Console.WriteLine("Soma: " + soma);
                Console.WriteLine(); Console.WriteLine();

            }
            else if (opcao != 0)
            {

                Console.WriteLine("Use o programa corretamente!");
                tolerancia++;

                if (tolerancia > 2)
                {
                    break;
                }

            }

        }

    }

}