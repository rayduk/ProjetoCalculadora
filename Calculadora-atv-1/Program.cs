float numero1, numero2;

Console.WriteLine("Digite o primeiro número: ");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segudo número: ");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação desejada (+,-,*,/): ");
string operacao = Console.ReadLine();

if (operacao == "+")
{

    float soma = numero1 + numero2;
    Console.WriteLine(soma);
}

if (operacao == "-")
{

    float subtracao = numero1 - numero2;
    Console.WriteLine(subtracao);
}