using Financas.UseCase.GastoUseCase.CriarGasto;
using Financas.UseCase.ReceitaUseCase.CriarReceita;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIs.Controller.GastoController;

[ApiController]
[Route("v1/[controller]/[action]")]
public class GastoController : ControllerBase
{
    private readonly ICadastrarGastoUseCase _cadastrarGastoUseCase;

    public GastoController(
        ICadastrarGastoUseCase cadastrarGastoUseCase
    )
    {
        _cadastrarGastoUseCase = cadastrarGastoUseCase;
    }

    [AllowAnonymous]
    [ProducesResponseType(201)]
    [ProducesResponseType(401)]
    [ProducesResponseType(400)]
    [Produces("application/json")]
    [HttpPost(Name = "PostCadastrarGasto")] 
    public CadastrarGastoUseCaseOutput PostCadastrarGasto([FromBody] CadastrarGastoUseCaseInput input)
    {
        return _cadastrarGastoUseCase.executeUseCase(input);
    }
}