using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.GastoUseCase.CriarGasto;

public class CadastrarGastoUseCaseInput : IUseCaseInput
{
    public string? TituloGasto { get; set; }
    public string? DescricaoGasto { get; set; }
    public string? Estabelecimento { get; set; }
    public long GastoDinheiro { get; set; }
    public DateTime DataGasto { get; set; }
}
