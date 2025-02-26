using System;

internal class Program
{
    double numero1, numero2;
    double soma = numero1 + numero2;
    double subtracao = numero1 - numero2;

    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        Console.ReadLine(numero1);
        Console.WriteLine("Digite o segundo número: ");
        Console.ReadLine(numero2);
        Console.WriteLine("A soma dos números é: " + soma);
        Console.WriteLine("A subtração dos números é: " + subtracao);

    }
}