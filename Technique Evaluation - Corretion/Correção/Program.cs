// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {
        
        while (true)
        {

            int opcao;

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("Questão 1");
            Console.WriteLine("Questão 2");
            Console.WriteLine("Questão 3");
            Console.WriteLine("Questão 4");
            Console.WriteLine("Questão 5");
            Console.WriteLine("");

            Console.Write("Escolha uma das questões: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {

                int[] vetor = new int[10];
                int quantidade = 0;

                Random numero = new Random();

                for (int i = 0; i < 10; i++)
                {

                    vetor[i] = numero.Next(100);

                    if (vetor[i] % 2 == 0)
                    {
                        quantidade++;
                    }

                }

                Console.WriteLine("");
                Console.WriteLine("Quantidade de Pares: " + quantidade);
                Console.WriteLine("");

            }
            else if (opcao == 2)
            {

                int[] vetor = new int[10];

                Random numero = new Random();

                for (int i = 0; i < 10; i++)
                {

                    vetor[i] = (numero.Next(100) - 50);

                    if (vetor[i] < 0)
                    {
                        vetor[i] = 0;
                    }

                }

                Console.WriteLine("");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Vetor["+i+"]: " + vetor[i]);
                }
                Console.WriteLine("");

            }
            else if (opcao == 3)
            {

                int[,] vetor = new int[4, 4];
                int somaM = 0, somaP = 0, somaS = 0, quantP=0;

                Random numero = new Random();

                for (int l = 0; l < 4; l++)
                {

                    for (int c = 0; c < 4; c++)
                    {

                        vetor[l, c] = numero.Next(100);
                        somaM += vetor[l, c];

                        if (l == c)
                        {
                            somaP += vetor[l, c];
                        }

                        if (l + c == 3)
                        {
                            somaS += vetor[l, c];
                        }

                        if (vetor[l, c] == 0 || vetor[l, c] == 1 || vetor[l, c] == 2 || vetor[l, c] % 2 != 0)
                        {
                            quantP++;
                        }

                    }

                }

                Console.WriteLine("");
                Console.WriteLine("Soma dos Elementos da Matriz: " + somaM);
                Console.WriteLine("Soma dos Elementos na Diagonal Primária: " + somaP);
                Console.WriteLine("Soma dos Elementos na Diagonal Secundária: " + somaS);
                Console.WriteLine("Quantidade de Elementos Primos na Matriz: " + quantP);
                Console.WriteLine("");

            }
            else if (opcao == 4)
            {

                int[,] vetor = new int[3, 3];

                Random numero = new Random();

                for (int l = 0; l < 3; l++)
                {

                    for (int c = 0; c < 3; c++)
                    {

                        if (l == 2 || c == 0)
                        {
                            vetor[l, c] = 1;
                        } else
                        {
                            vetor[l, c] = 0;
                        }

                    }

                }

                Console.WriteLine("");
                for (int l = 0; l < 3; l++)
                {

                    for (int c = 0; c < 3; c++)
                    {

                        Console.Write(vetor[l, c]+" ");

                    }

                    Console.WriteLine("");

                }
                Console.WriteLine("");

            }
            else if (opcao == 5)
            {

                int[,] vetor = new int[7, 4];
                int menor = 0, L=0, C=0;

                Random numero = new Random();

                for (int l = 0; l < 4; l++)
                {

                    for (int c = 0; c < 4; c++)
                    {

                        vetor[l, c] = numero.Next(100);

                        if (l == 0 && c == 0)
                        {
                            menor = vetor[l, c];
                            L = l;
                            C = c;  
                        } 
                        
                        if (menor > vetor[l, c])
                        {
                            menor = vetor[l, c];
                            L = l;
                            C = c;
                        }

                    }

                }

                Console.WriteLine("");
                Console.WriteLine("Matriz["+L+", "+C+"]: " + menor);
                Console.WriteLine("");

            }
            else
            {

                break;

            }

        }

    }

};