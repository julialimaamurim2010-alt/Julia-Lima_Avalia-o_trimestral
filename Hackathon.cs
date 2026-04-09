using System;

class Program
{
    static void Main()
    {
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };
        Random random = new Random();
        bool jogando = true;

        Console.WriteLine("--- BEM-VINDO AO DESAFIO ---");

        while (jogando)
        {
            Console.WriteLine("\nEscolha: [0] Pedra | [1] Papel | [2] Tesoura | [3] Sair");
            Console.Write("Sua jogada: ");

            if (!int.TryParse(Console.ReadLine(), out int escolhaJogador)) continue;

            if (escolhaJogador == 3)
            {
                jogando = false;
                Console.WriteLine("Saindo do jogo... Até a próxima!");
                break;
            }

            if (escolhaJogador < 0 || escolhaJogador > 2)
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                continue;
            }

            int escolhaPC = random.Next(0, 3);
            Console.WriteLine($"\nVocê: {opcoes[escolhaJogador]} vs PC: {opcoes[escolhaPC]}");

            // Lógica de Resultado
            if (escolhaJogador == escolhaPC)
            {
                Console.WriteLine(">> EMPATE!");
            }
            else if ((escolhaJogador == 0 && escolhaPC == 2) ||
                     (escolhaJogador == 1 && escolhaPC == 0) ||
                     (escolhaJogador == 2 && escolhaPC == 1))
            {
                Console.WriteLine(">> VOCÊ VENCEU! 🎉");
            }
            else
            {
                Console.WriteLine(">> VOCÊ PERDEU! 💀");
            }
        }
    }
}