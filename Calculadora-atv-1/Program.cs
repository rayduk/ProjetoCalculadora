internal class Program
{
    public static double num1;
    public static double num2;
    public static double resultado = 0;
    public static int operacao;

    private static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Opção: ");
        operacao = Convert.ToInt32(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"A soma é: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"A subtração é: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"A multiplicação é: {resultado}");
                break;
            case 4:
                resultado = num1 / num2;
                Console.WriteLine($"A divisão é: {resultado}");
                break;
            default:
                Console.WriteLine($"Não se encontr a operação");
                break;


        }
    }
}













