namespace AtividadeAbstracao.Classe.Entidades
{
    internal class PessoaJuridica : Contribuintes
    {
        //Campo
		private int funcionarios;

        //Propriedades
        protected int NumeroFuncionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}
        //Construtor
        public PessoaJuridica(double rendaAnual, string nome,int funcionario) : base(rendaAnual, nome)
        {
            NumeroFuncionarios = funcionario;
        }

        public override double Imposto(double rendaAnual)
        {
            double renda = RendaAnual;
            double imposto;
            if (NumeroFuncionarios > 10)
            {
                imposto = renda * 0.14;
            }
            else
            {
                imposto = renda * 0.16;
            }

            return imposto;
        }

    }
}
