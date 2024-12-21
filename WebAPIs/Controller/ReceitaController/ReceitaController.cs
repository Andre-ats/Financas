using Financas.UseCase.ReceitaUseCase.CriarReceita;
using Financas.UseCase.UsuarioUseCase.CriarUsuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIs.Controller.ReceitaController;

[ApiController]
[Route("v1/[controller]/[action]")]
public class ReceitaController : ControllerBase
{
    private readonly ICadastrarReceitaUseCase _cadastrarReceitaUseCase;

    public ReceitaController(
        ICadastrarReceitaUseCase cadastrarReceitaUseCase
    )
    {
        _cadastrarReceitaUseCase = cadastrarReceitaUseCase;
    }

    [AllowAnonymous]
    [ProducesResponseType(201)]
    [ProducesResponseType(401)]
    [ProducesResponseType(400)]
    [Produces("application/json")]
    [HttpPost(Name = "PostCadastrarReceita")] 
    public CadastrarReceitaUseCaseOutput PostCadastrarReceita([FromBody] CadastrarReceitaUseCaseInput input)
    {
        return _cadastrarReceitaUseCase.executeUseCase(input);
    }
}