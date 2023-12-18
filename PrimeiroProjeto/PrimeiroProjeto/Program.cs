// Screen Sound


using Microsoft.Win32;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Joy Division", new List<int> {10, 8, 6});
bandasRegistradas.Add("New Order", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite [1] para registrar uma banda.");
    Console.WriteLine("Digite [2] para mostrar todas as bandas.");
    Console.WriteLine("Digite [3] para avaliar uma banda.");
    Console.WriteLine("Digite [4] para exibir a média de uma banda.");
    Console.WriteLine("Digite [0] para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 0: 
            Console.WriteLine("Até breve!");
            break;
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MostrarMediaBanda();
            break;
        default:
            Console.WriteLine("Opção inexistente!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro das Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Lista das Bandas Registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione enter para voltar ao menu principal.");
    Console.ReadKey();

    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliação das Bandas");
    Console.Write("Digite o nome da banda que você deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a sua nota para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nNota {nota} foi registrada com sucesso para a banda {nomeBanda}");

        Thread.Sleep(5000);
        Console.Clear();
        ExibirMenu();

    }
        else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não registrada/encontrada.");

        Console.WriteLine("\nPressione enter para voltar ao menu principal.");
        Console.ReadKey();

        Console.Clear();
        ExibirMenu();
    }
}

void MostrarMediaBanda()
{
    Console.Clear();
    ExibirTitulo("Mostrando a Nota Média das Bandas");
    Console.Write("Digite o nome da banda que você deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        double media = bandasRegistradas[nomeBanda].Average();
        Console.WriteLine($"\nA nota média da banda {nomeBanda} foi de {media}.");

        Thread.Sleep(5000);
        Console.Clear();
        ExibirMenu();
    }
        else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não registrada/encontrada.");

        Console.WriteLine("\nPressione enter para voltar ao menu principal.");
        Console.ReadKey();

        Console.Clear();
        ExibirMenu();
    }
}

void ExibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirMenu();