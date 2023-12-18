// Screen Sound


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDeBandas = new List<string> { "Joy Divison", "New Order"};

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
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opção inexistente!");
            break;
    }

    

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeBanda);
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Lista das Bandas Registradas\n");

    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDeBandas[i]}");
    //}

    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione enter para voltar ao menu principal.");
    Console.ReadKey();

    Console.Clear();
    ExibirMenu();
}

ExibirMenu();