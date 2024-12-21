using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.ReceitaUseCase.CriarReceita;

public class CadastrarReceitaUseCaseInput : IUseCaseInput
{
    public string? TituloReceita { get; set; }
    public string? DescricaoReceita { get; set; }
    public string? Estabelecimento { get; set; }
    public long ReceitaDinheiro { get; set; }
    public DateTime DataReceita { get; set; }
}