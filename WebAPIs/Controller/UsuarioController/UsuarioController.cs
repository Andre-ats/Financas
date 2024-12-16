using Financas.UseCase.UsuarioUseCase.CriarUsuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIs.Controller.UsuarioController;

[ApiController]
[Route("v1/[controller]/[action]")]
public class UsuarioController : ControllerBase
{
    private readonly ICadastrarUsuarioUseCase _cadastrarUsuarioUseCase;

    public UsuarioController(
        ICadastrarUsuarioUseCase cadastrarUsuarioUseCase
    )
    {
        _cadastrarUsuarioUseCase = cadastrarUsuarioUseCase;
    }

    [AllowAnonymous]
    [ProducesResponseType(201)]
    [ProducesResponseType(401)]
    [ProducesResponseType(400)]
    [Produces("application/json")]
    [HttpPost(Name = "PostCadastrarUsuario")] 
    public CadastrarUsuarioUseCaseOutput PostCadastrarUsuario([FromBody] CadastrarUsuarioUseCaseInput input)
    {
        return _cadastrarUsuarioUseCase.executeUseCase(input);
    }
}