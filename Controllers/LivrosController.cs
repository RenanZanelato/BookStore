// Importando as bibliotecas necessárias.
// Fornece classes e interfaces para construir aplicativos web ASP.NET Core MVC.
using Microsoft.AspNetCore.Mvc;

// Contém interfaces e classes que definem coleções genéricas.
using System.Collections.Generic;

// Atributo que indica que esta classe é um controlador de API.
[ApiController]
// Define a rota padrão para o controlador.
// "[controller]" é um substituto para o nome da classe do controlador (sem a palavra "Controller").
[Route("[controller]")]
public class LivrosController : ControllerBase
{
    // Declaração de uma lista privada, estática e somente leitura chamada 'Livros'.
    // Esta lista contém dois nomes de livros como strings.
    private static readonly List<string> Livros = new List<string>
    {
        "O senhor dos aneis", "Star Wars"
    };

    // Método que é invocado quando uma solicitação HTTP GET é feita para o endpoint deste controlador.
    // Retorna a lista de livros com um status HTTP 200 (OK).
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return Ok(Livros);
    }
}
