using Atividade_HerancaPolimorfismo;

class Program
{
    public static void Main(string[] args)
    {
        Utilitario utilitario_n1 = new Utilitario();
        utilitario_n1.MarcaVeiculo = "Chevrolet";
        utilitario_n1.ValorVeiculo = 370000.00;
        utilitario_n1.ModeloVeiculo = "Super 4.050";
        utilitario_n1.QuantidadeLugaresUtilitario = 40;
        utilitario_n1.CorUtilitario = "Vermelho";
        double desconto_utilitario_n1 = utilitario_n1.DescontoVeiculo(9);

        Utilitario utilitario_n2 = new Utilitario();
        utilitario_n2.MarcaVeiculo = "Mercedes";
        utilitario_n2.ValorVeiculo = 560000.00;
        utilitario_n2.ModeloVeiculo = "Naghara Myn";
        utilitario_n2.QuantidadeLugaresUtilitario = 50;
        utilitario_n2.CorUtilitario = "Verde-Água";
        double desconto_utilitario_n2 = utilitario_n2.DescontoVeiculo(10);

        Empresarial empresarial_n1 = new Empresarial();
        empresarial_n1.MarcaVeiculo = "Volkswagen";
        empresarial_n1.ValorVeiculo = 980000.00;
        empresarial_n1.ModeloVeiculo = "Vip Version";
        empresarial_n1.CapacidadePesoEmpresarial = 4.2;
        empresarial_n1.QuantidadeEixosEmpresarial = 5;
        double desconto_empresarial_n1 = empresarial_n1.DescontoVeiculo(20);

        Console.WriteLine("\n----------------------------------------------------------------------\n");
        Console.WriteLine("                         Veículos Utilitários                         \n");
        Console.WriteLine(" Marca Utilitário: "+ utilitario_n1.MarcaVeiculo + ".");
        Console.WriteLine(" Valor Utilitário: R$ " + utilitario_n1.ValorVeiculo + ".");
        Console.WriteLine(" Modelo Utilitário: " + utilitario_n1.ModeloVeiculo + ".");
        Console.WriteLine(" Quantidade de Lugares: " + utilitario_n1.QuantidadeLugaresUtilitario + " lugares.");
        Console.WriteLine(" Cor do Utilitário: " + utilitario_n1.CorUtilitario + ".");
        Console.WriteLine(" Desconto: R$ " + desconto_utilitario_n1.ToString() + ".");
        Console.WriteLine(" Novo Valor: R$ " + utilitario_n1.NovoValor(desconto_utilitario_n1).ToString() + ".\n");
        Console.WriteLine(" Marca Utilitário: " + utilitario_n2.MarcaVeiculo + ".");
        Console.WriteLine(" Valor Utilitário: R$ " + utilitario_n2.ValorVeiculo + ".");
        Console.WriteLine(" Modelo Utilitário: " + utilitario_n2.ModeloVeiculo + ".");
        Console.WriteLine(" Quantidade de Lugares: " + utilitario_n2.QuantidadeLugaresUtilitario + " lugares.");
        Console.WriteLine(" Cor do Utilitário: " + utilitario_n2.CorUtilitario + ".");
        Console.WriteLine(" Desconto: R$ " + desconto_utilitario_n2.ToString() + ".");
        Console.WriteLine(" Novo Valor: R$ " + utilitario_n2.NovoValor(desconto_utilitario_n2).ToString() + ".");
        Console.WriteLine("\n----------------------------------------------------------------------\n");
        Console.WriteLine("\n----------------------------------------------------------------------\n");
        Console.WriteLine("                         Veículos Empresariais                        \n");
        Console.WriteLine(" Marca Empresarial: " + empresarial_n1.MarcaVeiculo + ".");
        Console.WriteLine(" Valor Empresarial: R$ " + empresarial_n1.ValorVeiculo + ".");
        Console.WriteLine(" Modelo Empresarial: " + empresarial_n1.ModeloVeiculo + ".");
        Console.WriteLine(" Capacidade de Peso: " + empresarial_n1.CapacidadePesoEmpresarial + " toneladas.");
        Console.WriteLine(" Quantidade de Eixo: " + empresarial_n1.QuantidadeEixosEmpresarial + " eixos.");
        Console.WriteLine(" Desconto: R$ " + desconto_empresarial_n1.ToString() + ".");
        Console.WriteLine(" Novo Valor: R$ " + empresarial_n1.NovoValor(desconto_empresarial_n1).ToString() + ".");
        Console.WriteLine("\n----------------------------------------------------------------------\n");
    }
}