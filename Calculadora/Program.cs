int soma = 0, numero;
string opcao;

Console.WriteLine("Calculadora básica C# \n 1- Somar \n 2-Subtrair \n 3-Multiplicar \n 4-Dividir");
Console.WriteLine("Selecione a opção desejada: ");

do
{
    opcao = Console.ReadLine() ?? "";  // Lê a opção do usuário e evita nulos
    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
    {
        Console.WriteLine("Opção inválida, tente novamente.");
        continue;
    }

} while (string.IsNullOrEmpty(opcao) || (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"));

do
{
    Console.WriteLine("Digite um número, ou 0 para parar: ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine($"Total dos números digitados: {soma}");
