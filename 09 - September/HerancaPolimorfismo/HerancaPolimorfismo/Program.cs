using GeneralizacaoPolimorfismo;
using HerancaPolimorfismo;

class Program
{
    public static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        n1.Nome = "João da Silva";
        n1.Sexo = "Masculino";

        FuncionarioN2 n2 = new FuncionarioN2();
        n2.Nome = "Marianne Mendonça";
        n2.Sexo = "Feminino";
        n2.Idade = 25;

        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------\n");
        Console.WriteLine("O nome do funcionário é " + n1.Nome + ", o sexo é " + n1.Sexo + " e sua comissão é RS " + n1.participacaoLucro().ToString()+".");
        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------\n");
        Console.WriteLine("O nome do funcionário é " + n2.Nome + ", o sexo é " + n2.Sexo + ", sua idade é " + n2.Idade.ToString() + " e sua comissão é RS " + n2.participacaoLucro().ToString() + ".");
        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------\n");
    }
}