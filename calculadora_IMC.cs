using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Vamos calcular seu IMC com base nos seus dados");
Console.WriteLine("Coloque sua altura e peso: ");
Console.WriteLine("Digite seu peso:");
float peso;
float altura;

float.TryParse(Console.ReadLine().Replace("." , "," ), out peso);
Console.WriteLine("Digite sua altura: ");
float.TryParse(Console.ReadLine().Replace(".", "," ), out altura);
float imc = peso / (float)Math.Pow(altura, 2);
Console.WriteLine($"{imc}");
if (imc < 18.5)
{
    Console.WriteLine("Magreza, procure um profissional");
}
else if (imc > 18.5 && imc < 24.9)
{
    Console.WriteLine("Normal, continue cuidando da sua saúde!");
}
else if (imc > 25.0 && imc < 29.9)
{
    Console.WriteLine("Sobrepeso, procure um profissional para saber mais");
}
else if (imc > 30.0 && imc < 39.9)
{
    Console.WriteLine("Obesidade, isso é um ruim, procure um profissional!");
}
else if (imc < 40.0)
{
    Console.WriteLine("Obesidade grave, isso é preocupante, procure um profissional urgentemente!");
}