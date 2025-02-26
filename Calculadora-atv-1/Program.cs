internal class Program
{
    double valor1;
    double valor2;
    double resultado = 0;
    int operacao;

    private static void Main(string[] args)
    {
        Console.Write("digite primer numero");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("digite segundo numero");
        valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Multiplicação");
        Console.WriteLine("2 - Divisão");
        Console.Write("Opção: ");
        operacao = Convert.ToInt32(Console.ReadLine());
        switch (operacao)
        {
            case 1:
                resultado = num1 * num2;
                Console.WriteLine($"A multiplicação é: {resultado}");
                break;
            case 2:
                resultado = num1 / num2;
               

        }

    }






    }
}




