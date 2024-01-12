using ProjetoEstacionamentoDois.Models;


Estacionamento garagem = new Estacionamento(10,5);

Console.WriteLine("Bem vindo ao estacionamento do Arthur! ");
Console.WriteLine("O preço para entrar é R$ 10,00 reais e o preço por hora é R$ 5,00 reais ");
Console.WriteLine("Aperte qualquer botão");
Console.ReadLine();
string menu = "";

while (menu != "4")
{


Console.Clear();
Console.WriteLine("Escolha alguma das opções: ");
Console.WriteLine("Opção 1: Adicionar Veículo ");
Console.WriteLine("Opção 2: Remover veículo ");
Console.WriteLine("Opção 3: Listar veiculos estacionados ");
Console.WriteLine("Opção 4: Sair ");
menu = Console.ReadLine();


switch (menu)
{
    case "1":
    garagem.AdicionarVeiculo();
    break;

    case "2":
    garagem.RemoverVeiculo();
    break;

    case "3":
    garagem.Listar();
    break;

    case "4":
    Console.WriteLine("Programa encerrado");
    break;


    default:
    Console.WriteLine("Opção inválida!");
    break;


}
}





