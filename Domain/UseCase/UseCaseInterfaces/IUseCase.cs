namespace VinilProjeto.UseCase.UseCaseInterfaces;

public abstract class IUseCase<TI, TO>
    where TI: IUseCaseInput
    where TO: IUseCaseOutput
{
    public IUseCase(){}

    public TO executeUseCase(TI _useCaseInput)
    {
        TO _useCaseOutput = executeService(_useCaseInput);
        return _useCaseOutput;
    }

    protected abstract TO executeService(TI _useCaseInput);
}