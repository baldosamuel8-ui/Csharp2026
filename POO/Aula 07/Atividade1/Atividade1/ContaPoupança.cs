namespace Atividade1
{
    internal class ContaPoupança : Conta
    {
        private double taxaDeJuros;

        public void AtualizacaoDeSaldo()
        {
            
        }
        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
    }


}
