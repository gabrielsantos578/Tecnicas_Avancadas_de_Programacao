// See https://aka.ms/new-console-template for more information



////////// Questão 1 //////////

int[] vetor1 = new int[10];
int inteiro1, quant1 = 0;
double resto1;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o numero " + (i + 1) + ": ");
    vetor1[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    inteiro1 = vetor1[i] / 2;
    resto1 = vetor1[i];
    resto1 = resto1 / 2;

    if (resto1 - inteiro1 == 0)
    {
        quant1++;
    }
}

Console.WriteLine("A quantidade de valores pares informados é " + quant1 + ".");


////////// Questão 2 //////////

int[] vetor2 = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o número " + (i + 1) + ": ");
    vetor2[i] = Convert.ToInt32(Console.ReadLine());

    if(vetor2[i] < 0)
    {
        vetor2[i] = 0;
    }
}

Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Vetor[" + i + "] = " + vetor2[i]);
}



////////// Questão 3 //////////

int[,] matriz3 = new int[4, 4];
int somaT = 0, somaDP=0, somaDS=0; 

for (int l = 0; l < 4; l++)
{

    for (int c = 0;  c < 4; c++)
    {

        Console.Write("Matriz[" + l+", "+c+ "]: ");
        matriz3[l, c] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        somaT += matriz3[l, c];

        if (l == c)
        {
            somaDP += matriz3[l, c];
        }

    }

}

for (int l = 0, c = 3; l < 4; l++, c--) {
    somaDS += matriz3[l, c];
}

Console.WriteLine("Soma Elementos: " + somaT);
Console.WriteLine("Soma Diagonal Principal: " + somaDP);
Console.WriteLine("Soma Diagonal Secundária: " + somaDS);

for (int l=0; l < 4; l++)
{

    for (int c = 0; c < 4; c++)
    {
        int conf = 0;

        for (int n=2; n < matriz3[l, c]; n++)
        {
            double resto3 = matriz3[l, c];
            resto3 /= n;
            int inteiro3 = matriz3[l, c] / n;

            if (resto3 - inteiro3 == 0)
            {
                conf++;
            }

        }

        if (matriz3[l, c]==0 && matriz3[l, c] == 1 && matriz3[l, c] == 2)
        {
            Console.WriteLine("Matriz[" + l + ", " + c + "]: " + matriz3[l, c]);
        }
        else if (conf == 0)
        {
            Console.WriteLine("Matriz[" + l + ", " + c + "]: " + matriz3[l, c]);
        }

    }

}



////////// Questão 4 //////////

int[,] matriz4 = new int[3, 3];

for (int l = 0; l < 3; l++)
{

    for (int c = 0; c < 3; c++)
    {

        if (c==0 || l ==2)
        {
            matriz4[l, c] = 1;
        } else
        {
            matriz4[l, c] = 0;
        }

        Console.Write(matriz4[l, c]+" ");

    }

    Console.WriteLine();

}



////////// Questão 5 //////////

int[,] matriz5 = new int[7, 4];
int[] casa = new int[2];
int menor=0;

for (int l = 0; l < 3; l++)
{

    for (int c = 0; c < 3; c++)
    {
        matriz5[l, c] = ((2 * ((c * c) * (l + l))) - (7 * l) + c) * (l * (l + l));

        if (l==0 && c==0)
        {
            menor = matriz5[l, c];
        }

        if (menor > matriz5[l, c])
        {
            menor = matriz5[l, c];
            casa[0] = l;
            casa[1] = c;
        }

    }

}

Console.Write("Matriz[" + casa[0] + ", " + casa[1] + "] = " + menor);

