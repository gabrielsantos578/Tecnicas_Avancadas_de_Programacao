/******************************************************************************

                        List of Exercises - Vector

 Ex 4 º - Ler  um  vetor  com  10  nomes  de  pessoas,  após  pedir  que  o  
usuário  digite  um  nome  qualquer  de pessoa. Escrever a mensagem “ACHEI”, 
se o nome estiver armazenado no vetor C ou “NÃO ACHEI” caso contrário.  

*******************************************************************************/

using System.Runtime.CompilerServices;

internal class Promgram
{
    private static void Main(string[] args)
    {

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

    }

}