using LojaPOO.Models;

namespace LojaPOO.Repositories;

public class ClienteRepositorio
{
    private List<Cliente> clientes = new();
    private int proximoId = 1;

    public void Cadastrar(Cliente cliente)
    {
        cliente.Id = proximoId++;
        clientes.Add(cliente);
        Console.WriteLine("Cliente cadastrado com sucesso.");
    }

    public void Listar()
    {
        if (!clientes.Any())
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
            return;
        }

        foreach (var cliente in clientes)
            cliente.Exibir();
    }

    public void Atualizar(int id, Cliente novo)
    {
        var cliente = clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return;
        }

        cliente.Nome = novo.Nome;
        cliente.Email = novo.Email;
        Console.WriteLine("Cliente atualizado com sucesso.");
    }

    public void Remover(int id)
    {
        var cliente = clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return;
        }

        clientes.Remove(cliente);
        Console.WriteLine("Cliente removido com sucesso.");
    }
}