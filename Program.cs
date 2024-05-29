using static System.Net.Mime.MediaTypeNames;

List<string> listaBandas = new List<string>();

ExibirMenu();

void ExibirMenu()
{
    Console.WriteLine("Seja bem vindo à sua lista de Bandas Favoritas");
    Console.WriteLine("\nPara adicionar uma banda à lista digite 1");
    Console.WriteLine("Para Exibir sua lista digite 2");
    Console.WriteLine("Para sair do aplicativo digite 3");
    string escolha = Console.ReadLine();
    int opcaoEscolhida = int.Parse(escolha);
    if (opcaoEscolhida == 1)
    {
        AdicionarBanda();
    } else if (opcaoEscolhida == 2)
    {
        ExibirLista();
    } else if (opcaoEscolhida == 3)
    {
        Console.WriteLine("Você encerrou o programa");
    }
    Console.Clear();
}

void AdicionarBanda()
{
    Console.Clear();
    Console.WriteLine("Registre a sua banda !");
    Console.Write("\nAdicione uma banda: ");
    string banda = Console.ReadLine()!;
    listaBandas.Add(banda);
    Console.WriteLine($"\nA banda {banda} foi adicionado com sucesso !");
    Thread.Sleep(1500);
    Console.Clear();
    ExibirMenu();
}

void ExibirLista()
{
    Console.Clear();
    Console.WriteLine("Sua lista de bandas favoritas");
    Console.WriteLine();
    for (int i = 0; listaBandas.Count > i ; i++)
    {
        Console.WriteLine( + listaBandas[i]);
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}