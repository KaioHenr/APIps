using APINomeEnde.Model;
using Microsoft.AspNetCore.Mvc;

namespace APINomeEnde.Controller;
[Route("APINomeEnde/[controller]")]
[ApiController]

public class PessoaController : ControllerBase
{
    
    [HttpGet]
    [Route("hellow/{arroz}")]
    
    public string hellow(string arroz)
    {
        Console.WriteLine("hellow word!!");
        Console.WriteLine(arroz);
        return arroz+"123";
    }
    public ActionResult<List<Pessoa>> BuscarTodosUsuarios()
    {
        return Ok();
    }
}