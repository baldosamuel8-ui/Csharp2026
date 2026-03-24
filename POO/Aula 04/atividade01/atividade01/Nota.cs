namespace atividade01
{
    internal class Nota
    {
        public string nome;
        public double resultado;
        public double nota1;
        public double nota2;
        public double nota3;
        public double NotaFinal;

        public double Notas()
        {
            return resultado = nota1 + nota2 + nota3;
        }

        public void ReprovadoOuAprovado()
        {
            if(resultado >= 60)
            {
                Console.WriteLine("Aprovado");
            }
            else if (resultado<60)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
       

        
    }
}
