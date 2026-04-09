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
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

         public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

        public override string ToString()
        {
            return $"Dados do cliente - {Tipo.ContaNormal}: \n" + $"\tNome: {DadosCliente.nome}\n" + $"\tCPF: {cliente.cpf}\n" + $"\tNumero: {NumeroConta}\n" + $"\tSaldo: {SaldoConta:C}";
        }

    }
}
