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
       

    }
}




