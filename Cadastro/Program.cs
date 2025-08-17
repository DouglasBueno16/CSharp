string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadLine() ?? string.Empty;

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Sair");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
