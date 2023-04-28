/******************************************************************************

                        List of Exercises - Menu

 > Organize o programa em forma de o usuário ter acesso as funcionalidades 
através de menus. Escreva o seu código utilizando os subprogramas que achar 
conveniente para ter um código legível e bem escrito.

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

        int opcao = 1;

        while (opcao != 0)
        {

            opcao = Menu();

            if (opcao == 11)
            {
                Ex11();
            }
            else if (opcao == 12)
            {
                Ex12();
            }
            else if (opcao == 13)
            {
                Ex13();
            }
            else if (opcao == 14)
            {
                Ex14();
            }
            else if (opcao == 15)
            {
                Ex15();
            }
            else if (opcao == 16)
            {
                Ex16();
            }
            else if (opcao == 17)
            {
                Ex17();
            }
            else if (opcao == 21)
            {
                Ex21();
            }
            else if (opcao == 22)
            {
                Ex22();
            }
            else if (opcao == 23)
            {
                Ex23();
            }
            else if (opcao == 24)
            {
                Ex24();
            }
            else if (opcao == 25)
            {
                Ex25();
            }
            else if (opcao == 26)
            {
                Ex26();
            }
            else if (opcao == 0)
            {
                Encerrar();
            }
            else
            {
                Tolerancia();
            }

        }

    }


    /////////////  Menu  /////////////

    static int Menu()
    {

        int opcao;

        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("------------ Menu ------------");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(" - Vetor: ");
        Console.WriteLine();
        Console.WriteLine("[11] Exercício 01");
        Console.WriteLine("[12] Exercício 02");
        Console.WriteLine("[13] Exercício 03");
        Console.WriteLine("[14] Exercício 04");
        Console.WriteLine("[15] Exercício 05");
        Console.WriteLine("[16] Exercício 06");
        Console.WriteLine("[17] Exercício 07");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(" - Matriz: ");
        Console.WriteLine();
        Console.WriteLine("[21] Exercício 01");
        Console.WriteLine("[22] Exercício 02");
        Console.WriteLine("[23] Exercício 03");
        Console.WriteLine("[24] Exercício 04");
        Console.WriteLine("[25] Exercício 05");
        Console.WriteLine("[26] Exercício 06");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(" - Programa: ");
        Console.WriteLine();
        Console.WriteLine("[0] Encerrar Programa");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine(); Console.WriteLine();
        Console.Write("Digite a opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); Console.WriteLine();

        return opcao;

    }


    /////////////  Vetor - Exercício 01  /////////////

    static int Ex11()
    {

        Console.WriteLine(" > Vetor - Exercício 1: ");
        Console.WriteLine();

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

        Console.WriteLine();
        return 0;

    }


    /////////////  Vetor - Exercício 02  /////////////

    static int Ex12()
    {

        Console.WriteLine(" > Vetor - Exercício 2: ");

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

        Console.WriteLine();
        return 0;

    }


    /////////////  Vetor - Exercício 03  /////////////

    static int Ex13()
    {

        Console.WriteLine(" > Vetor - Exercício 3: ");
        Console.WriteLine();

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

        Console.WriteLine();
        return 0;

    }


    /////////////  Vetor - Exercício 04  /////////////

    static int Ex14()
    {

        Console.WriteLine(" > Vetor - Exercício 4: ");
        Console.WriteLine();

        String[] vetor = new String[10];

        Console.Write("Escreva um nome: ");
        vetor[0] = Console.ReadLine();

        for (int i = 1; i < 10; i++)
        {

            Console.Write("Escreva um outro nome: ");
            vetor[i] = Console.ReadLine();

        }
        Console.WriteLine();


        Console.WriteLine("Observação: Caso queira encerrar, digite 0.");
        String opcao = "0";

        while (true)
        {

            Console.Write("Escreva um nome e iremos busca-lo: ");
            opcao = Console.ReadLine();

            Console.WriteLine();

            int conf = 0;
            if (opcao.Equals("0"))
            {
                break;

            }
            else
            {

                for (int i = 0; i < 10; i++)
                {

                    if (opcao.Equals(vetor[i]))
                    {
                        Console.WriteLine("Achei!");
                        conf = 1;
                        break;

                    }

                }

                if (conf == 0)
                {
                    Console.WriteLine("Não achei!");

                }

            }
            Console.WriteLine();

        }

        return 0;

    }


    /////////////  Vetor - Exercício 05  /////////////

    static int Ex15()
    {

        Console.WriteLine(" > Vetor - Exercício 5: ");
        Console.WriteLine();

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

        return 0;

    }


    /////////////  Vetor - Exercício 06  /////////////

    static int Ex16()
    {

        Console.WriteLine(" > Vetor - Exercício 6: ");
        Console.WriteLine();

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

        for (int inte = (i-1); inte > -1; inte--)
        {

            Console.WriteLine("Vetor Ímpar [" + inte + "]: " + vetorImpar[inte]);

        }

        Console.WriteLine();
        return 0;

    }


    /////////////  Vetor - Exercício 07  /////////////

    static int Ex17()
    {

        Console.WriteLine(" > Vetor - Exercício 7: ");
        Console.WriteLine();

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
        } Console.WriteLine();

        for (int i = 0; i < T; i++)
        {
            Console.Write("Vetor 1 [" + i + "]: ");
            vetor2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();

        comparacaoVetor(vetor1, vetor2, T);

        Console.WriteLine();
        return 0;

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



    /////////////  Matriz - Exercício 01  /////////////

    static int Ex21()
    {

        Console.WriteLine(" > Matriz - Exercício 1: ");
        Console.WriteLine();

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

        Console.WriteLine();
        return 0;

    }


    /////////////  Matriz - Exercício 02  /////////////

    static int Ex22()
    {

        Console.WriteLine(" > Matriz - Exercício 2: ");
        Console.WriteLine();

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

        Console.WriteLine();
        return 0;

    }


    /////////////  Matriz - Exercício 03  /////////////

    static int Ex23()
    {

        Console.WriteLine(" > Matriz - Exercício 3: ");
        Console.WriteLine();

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

        Console.WriteLine();
        return 0;

    }


    /////////////  Matriz - Exercício 04  /////////////

    static int Ex24()
    {

        Console.WriteLine(" > Matriz - Exercício 4: ");
        Console.WriteLine();

        int c1, l1, c2, l2;
        Console.Write("Matriz 1 - Quant. Colunas: ");
        c1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Matriz 1 - Quant. Linhas: ");
        l1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Matriz 2 - Quant. Colunas: ");
        c2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Matriz 2 - Quant. Linhas: ");
        l2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); Console.WriteLine();

        double[,] matriz1 = new double[l1, c1];
        double[,] matriz2 = new double[l2, c2];
        double[] vetor1 = new double[l1];
        double[] vetor2 = new double[c2];
        double[,] matrizM = new double[l1, c2];

        Random numero = new Random();

        Console.WriteLine("----  Matriz 1  ----"); Console.WriteLine();
        for (int c = 0; c < l1; c++)
        {
            for (int l = 0; l < c1; l++)
            {
                matriz1[c, l] = numero.Next(99);
                if (matriz1[c, l] < 10)
                {
                    Console.Write(" " + matriz1[c, l] + " ");
                }
                else
                {
                    Console.Write(matriz1[c, l] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int c = 0; c < l1; c++)
        {

            vetor1[c] = 0;

            for (int l = 0; l < c1; l++)
            {

                vetor1[c] += matriz1[c, l];

            }

        }



        Console.WriteLine("----  Matriz 2  ----"); Console.WriteLine();
        for (int c = 0; c < l2; c++)
        {
            for (int l = 0; l < c2; l++)
            {
                matriz2[c, l] = numero.Next(99);
                if (matriz2[c, l] < 10)
                {
                    Console.Write(" " + matriz2[c, l] + " ");
                }
                else
                {
                    Console.Write(matriz2[c, l] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int c = 0; c < c2; c++)
        {

            vetor2[c] = 0;

            for (int l = 0; l < l2; l++)
            {

                vetor2[c] += matriz2[l, c];

            }

        }


        Console.WriteLine("--  Multiplicação  --"); Console.WriteLine();
        for (int c = 0; c < l1; c++)
        {
            for (int l = 0; l < c2; l++)
            {
                matrizM[c, l] = vetor1[c] * vetor2[l];
                if (matrizM[c, l] < 10000)
                {
                    Console.Write("  " + matrizM[c, l] + " ");
                }
                else if (matrizM[c, l] < 100000)
                {
                    Console.Write(" " + matrizM[c, l] + " ");
                }
                else
                {
                    Console.Write(matrizM[c, l] + " ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        return 0;

    }


    /////////////  Matriz - Exercício 05  /////////////

    static int Ex25()
    {

        Console.WriteLine(" > Matriz - Exercício 5: ");
        Console.WriteLine();

        int col, lin;
        Console.Write("Matrizes - Quant. Colunas: ");
        col = Convert.ToInt32(Console.ReadLine());
        Console.Write("Matrizes - Quant. Linhas: ");
        lin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); Console.WriteLine();

        double[,] matriz1 = new double[lin, col];
        double[,] matriz2 = new double[lin, col];
        double[,] matrizS = new double[lin, col];

        Random numero = new Random();

        Console.WriteLine("----  Matriz 1  ----"); Console.WriteLine();
        for (int c = 0; c < lin; c++)
        {
            for (int l = 0; l < col; l++)
            {
                matriz1[c, l] = numero.Next(99);
                if (matriz1[c, l] < 10)
                {
                    Console.Write(" " + matriz1[c, l] + " ");
                }
                else
                {
                    Console.Write(matriz1[c, l] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("----  Matriz 2  ----"); Console.WriteLine();
        for (int c = 0; c < lin; c++)
        {
            for (int l = 0; l < col; l++)
            {
                matriz2[c, l] = numero.Next(99);
                if (matriz2[c, l] < 10)
                {
                    Console.Write(" " + matriz2[c, l] + " ");
                }
                else
                {
                    Console.Write(matriz2[c, l] + " ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        Console.WriteLine("------  Soma  ------"); Console.WriteLine();
        for (int c = 0; c < lin; c++)
        {
            for (int l = 0; l < col; l++)
            {
                matrizS[c, l] = matriz1[c, l] + matriz2[c, l];
                if (matrizS[c, l] < 10)
                {
                    Console.Write("  " + matrizS[c, l] + " ");
                }
                else if (matrizS[c, l] < 100)
                {
                    Console.Write(" " + matrizS[c, l] + " ");
                }
                else
                {
                    Console.Write(matrizS[c, l] + " ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        return 0;

    }


    /////////////  Matriz - Exercício 06  /////////////

    static int Ex26()
    {

        Console.WriteLine(" > Matriz - Exercício 6: ");
        Console.WriteLine();

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

        Console.WriteLine();
        return 0;

    }



    /////////////  Encerrar  /////////////

    static int Encerrar()
    {

        Console.WriteLine(" > Programa Encerrado!");
        Console.WriteLine();
        Console.WriteLine("------------------------------");

        return 0;

    }


    /////////////  Tolerancia  /////////////

    static int Tolerancia()
    {

        Console.WriteLine(" > A opção informada não existe!");
        Console.WriteLine();

        return 0;

    }

};
