namespace Atividade1
{
    internal class ContaParaEmpresa : Conta
    {
        private double limite;

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public ContaParaEmpresa(int numeroConta, string titularConta, double saldoConta, double LimiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = LimiteConta;
        }

        public void Emprestimo(double quantia)
        {
            LimiteEmprestimo -= quantia;
            SaldoConta += quantia;
        }

    }
}
