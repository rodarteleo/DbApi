using Microsoft.AspNetCore.Mvc;
using DbApi.Models;

namespace DbApi.Controllers;

[ApiController]
[Route("clientes")]
public class ClientesController : ControllerBase
{
    [HttpGet]

    public IActionResult ObterTodos()
    {
        // return StatusCode(200, "Healthy");
        // to do: buscar todos os clientes registrados no banco de dados.

        List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente()
            {
                Nome = "João Silva",
                Telefone = "(11) 98765-4321",
                Email = "joao@silva.com",
                Endereco = "Rua A, 123, São Paulo, SP"
            },
            new Cliente()
            {
                Nome = "Maria Souza",
                Telefone = "(11) 98765-1234",
                Email = "maria@souza.com",
                Endereco = "Rua B, 456, Rio de Janeiro, RJ"
            },
            new Cliente()
            {
                Nome = "Carlos Oliveira",
                Telefone = "(11) 98765-5678",
                Email = "carlos@oliveira.com",
                Endereco = "Rua C, 789, Belo Horizonte, MG"
            }
        };

        return Ok(clientes);
    }

    [HttpPost]
    public IActionResult Criar([FromBody] Cliente clientes)
    {
        // return StatusCode(200, "Healthy");
        // to do: salvar o cliente no banco de dados.
        return Created();
    }

}