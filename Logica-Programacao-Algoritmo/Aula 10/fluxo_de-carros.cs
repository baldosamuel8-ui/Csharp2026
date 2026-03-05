using System; // Biblioteca básica para usar Console, DateTime, etc.

class Program
{
    static void Main()
    {
        // Variável que guarda o total de turistas no parque
        int totalTuristas = 0;

        // Variável que controla o loop do programa
        bool executando = true;

        // Título do sistema
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses\n");

        Console.ResetColor();

        // Loop principal (fica rodando até o usuário digitar "sair")
        while (executando)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Digite o fluxo de carro (entrada/saida)");
            Console.Write("ou sair para encerrar a aplicação: ");
            Console.ResetColor();

            string fluxo = Console.ReadLine().ToLower(); // Lê a opção do usuário

            // Se o usuário quiser sair
            if (fluxo == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSaindo do aplicativo...");
                Console.WriteLine("Aplicativo encerrado.");
                Console.ResetColor();

                executando = false; // Encerra o loop
            }
            // Se for entrada ou saída
            else if (fluxo == "entrada" || fluxo == "saida")
            {
                Console.Write("Digite o número de turistas: ");

                // Tenta converter o valor digitado para número
                if (int.TryParse(Console.ReadLine(), out int quantidade))
                {
                    // Mostra data e hora atual
                    DateTime agora = DateTime.Now;

                    if (fluxo == "entrada")
                    {
                        totalTuristas += quantidade; // Soma ao total

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nEntrada registrada em: {agora}");
                        Console.WriteLine($"Entrada de {quantidade} turistas registrada.");
                    }
                    else
                    {
                        totalTuristas -= quantidade; // Subtrai do total

                        // Impede que fique negativo
                        if (totalTuristas < 0)
                            totalTuristas = 0;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nSaída registrada em: {agora}");
                        Console.WriteLine($"Saída de {quantidade} turistas registrada.");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Total de turistas no parque: {totalTuristas}\n");

                    Console.ResetColor();
                }
                else
                {
                    // Caso o usuário digite algo que não seja número
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Digite um número válido.\n");
                    Console.ResetColor();
                }
            }
            else
            {
                // Caso digite algo diferente de entrada/saida/sair
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.\n");
                Console.ResetColor();
            }
        }
    }
}