namespace Banco
{
    internal class Conta
    {
        //Campos ou Atributos
        private int numero;
        private string titular;
        private double saldo;

        //Construtor
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;
        }

        public Conta(int numero, string titular, double saldo): this(numero, titular)//Reaproveitamento de Construtor anterior
        {
            this.saldo = saldo;
        }

        //Metodos
        public void Deposito(double quantia)
        {
            saldo += quantia;
        }
        public void Saque(double quantia)
        {
            saldo -= quantia;
        }
        public void Dados()
        {
            Console.WriteLine("Dados da conta cadastrada: ");
            Console.Write($"\tTitular: {titular}\n" + $"\t Numero da conta: {numero}\n" + $"\tSaldo da conta: {saldo}\n");
        }
    }
}
