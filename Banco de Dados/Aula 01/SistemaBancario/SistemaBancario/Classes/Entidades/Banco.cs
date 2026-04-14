namespace SistemaBancario.Classes.Entidades
{
    /// <summary>
    /// Classe que representa uma conta bancaria com operações basicas Implementa as regras de negocio.
    /// </summary>
    internal class Banco
    {
        //campo
        ///<sumary>
        ///Taxa fixa cobrada em cada operação de saque
        ///<sumary>

        private const double taxaSaque = 5.00;

        //Propriedades
        ///<summary>
        ///identificador unico da conta bancaria no banco de dados (gerado automaticamente)
        ///</summary>
        ///
        public int Id { get; set; }

        ///<summary>
        ///Numero da conta bancaria 'init' garante que o valor so pode ser atribuido na criação(imutavel apos a construção)
        ///</summary>
        ///
        public int NumeroConta { get; init; }

        ///<summary>
        ///Nome do titular da conta
        ///</summary>
        
        public string Titular { get; set; }
        
        ///<summary>
        ///'private set' impede alteração direta - só pode mudar através de Deposito ou Saque
        ///<summary>
        
        public double Saldo { get; private set; }

        //Construtor
        public Banco()
        {

        }

        public Banco(int numeroConta, string titular, double saldo = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {

        }
    }
}
