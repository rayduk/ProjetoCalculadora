
internal class Program
{
    public static double num1;
    public static double num2;
    public static double resultado = 0;
    public static int operacao;

    private static void Main(string[] args)
    {
        Console.Write("digite primeiro numero ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("digite segundo numero ");
        num2 = Convert.ToDouble(Console.ReadLine());

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
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"A divisão é: {resultado}");
                }
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}