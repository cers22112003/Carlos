using LojaPOO.Models;
using LojaPOO.Repositories;

var repositorio = new ClienteRepositorio();

int opcao;
do
{
    Console.WriteLine("\n--- Menu Cliente ---");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Listar Clientes");
    Console.WriteLine("3 - Editar Cliente");
    Console.WriteLine("4 - Remover Cliente");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            repositorio.Cadastrar(new Cliente { Nome = nome, Email = email });
            break;

        case 2:
            repositorio.Listar();
            break;

        case 3:
            Console.Write("ID do cliente a editar: ");
            int.TryParse(Console.ReadLine(), out var idEditar);
            Console.Write("Novo nome: ");
            var novoNome = Console.ReadLine();
            Console.Write("Novo email: ");
            var novoEmail = Console.ReadLine();
            repositorio.Atualizar(idEditar, new Cliente { Nome = novoNome, Email = novoEmail });
            break;

        case 4:
            Console.Write("ID do cliente a remover: ");
            int.TryParse(Console.ReadLine(), out var idRemover);
            repositorio.Remover(idRemover);
            break;
    }

} while (opcao != 0);

Console.WriteLine("Programa encerrado.");