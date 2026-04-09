Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("#####################################");
Console.WriteLine("Conversor de temperatura😁😘🔥");
Console.Write("Digite a temperatura em C°: ");
float.TryParse(Console.ReadLine(), out float celsius);
float resultado = (celsius * 9 / 5) + 32;
Console.WriteLine($"A temperatura é C°: {celsius}\nA conversão em F°: {resultado}");

Console.WriteLine("####################################");

Console.Write("Digite a temperatura em F°: ");

if (float.TryParse(Console.ReadLine(), out float fahrenheit))
{
    float resultado1 = (fahrenheit - 32) * 5 / 9;

    Console.WriteLine($"A temperatura é F°: {fahrenheit}");
    Console.WriteLine($"A conversão em C°: {resultado1:F2}");
}
Console.WriteLine("####################################");

Console.Write("Digite a temperatura em K°: ");

if (float.TryParse(Console.ReadLine(), out float kelvin))
{
    float resultado4 = (kelvin - 273.15f) * 9 / 5 + 32;

    Console.WriteLine($"A temperatura é K: {kelvin}");
    Console.WriteLine($"A conversão em C°: {resultado:F2}");
}
Console.WriteLine("####################################");

Console.Write("Digite a temperatura em Kelvin (K): ");

if (float.TryParse(Console.ReadLine(), out float Kelvin))
{
    float resultado4 = (kelvin - 273.15f) * 9 / 5 + 32;
    Console.WriteLine($"Conversão em F°: {resultado:F2}");
}
Console.ReadLine();