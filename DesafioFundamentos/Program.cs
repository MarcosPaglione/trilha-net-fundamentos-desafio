using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Title = ("Sistema de estacionamento");
Console.WriteLine("Seja bem vindo ao sistema de estacionamento\n");

Console.Write("Digite o preço inicial: ");
// Implementado corrige bug do . e ,
string precoInicialString = (Console.ReadLine()).Replace(".",",") ;
precoInicial = Convert.ToDecimal(precoInicialString);

Console.Write("\nAgora digite o preço por hora: ");
// Implementado corrige bug do . e ,
string precoPorHoraString = (Console.ReadLine()).Replace(".",",") ;
precoPorHora = Convert.ToDecimal(precoPorHoraString);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\n Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou \n");
Console.WriteLine("  DEUS Seja Louvado! \n");
