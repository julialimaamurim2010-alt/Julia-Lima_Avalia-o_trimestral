Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Vamos calcular uma PA!");
Console.Write("Digite até que número você quer calcular a PA:");
 int quantidade = int.Parse(Console.ReadLine());
Console.Write("Digite a razão da PA:");
    int razao = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidade; i = i + razao)
{
   Console.Write($"{i}👉");
}
Console.Write("🔚Fim da PA!");