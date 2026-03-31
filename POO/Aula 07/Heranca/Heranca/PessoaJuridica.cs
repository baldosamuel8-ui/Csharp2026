namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        //Campos
        private double limite;

        //Propriedades
        public double limiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public PessoaJuridica(string titularConta, int numeroConta, double limiteConta) : base(titularConta, numeroConta)
        {
            limiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            limiteEmprestimo = limiteConta;
        }

        //Metodos
        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}
