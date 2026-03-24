using System.Security.Cryptography;

namespace atividade02
{
    internal class Salario
    {
        public string nome;
        public double SalarioBruto;
        public double SalarioLiquido;
        public double AumentoporPorcentagem;
        public double dados;
        public double imposto;

        public double DadosImposto()
        {
            return SalarioLiquido = SalarioBruto - imposto;
        }

        public void ResultadoSalario()
        {
            Console.WriteLine($"Dados do Funcionario");
            Console.WriteLine($"Nome do Funcionario:{nome}");
            Console.WriteLine($"Salario Liquido:{SalarioLiquido}");
        }

        public double Resultado()
        {
            AumentoporPorcentagem = AumentoporPorcentagem * 0.01;
            return dados = SalarioLiquido * AumentoporPorcentagem;
        }

        public void Saida()
        {
            Console.WriteLine($"Dados Atualizados");
            Console.WriteLine($"Nome do Funcionario:{nome}");
            Console.WriteLine($"Salario atualizado:{SalarioLiquido + dados}");
        }
    }
}
