namespace Master
{
    internal class Conta : IOperacao
    {
        //Campos
        private Pessoa cliente;
        private int numero;
        private double saldo;

        //Propriedades
        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }

        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Pessoa DadosCliente
        {
            get { return cliente ; }
            set { cliente = value; }
        }

        //Construtores
        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }

        //Metodos
        void IOperacao.Deposito(double quantia)
        {
            throw new NotImplementedException();
        }

        void IOperacao.Saque(double qauntia)
        {
            throw new NotImplementedException();
        }
    }
}
