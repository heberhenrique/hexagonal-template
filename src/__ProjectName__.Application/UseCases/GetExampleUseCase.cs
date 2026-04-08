
using System;
using System.Threading.Tasks;
using __ProjectName__.Application.Ports.Input;
using __ProjectName__.Application.Ports.Output;

namespace __ProjectName__.Application.UseCases;
public class GetExampleUseCase : IGetExampleUseCase
{
    private readonly IExampleRepository _repository;

    public GetExampleUseCase(IExampleRepository repository)
    {
        _repository = repository;
    }

    public Task<string> ExecuteAsync(Guid id)
        => _repository.GetAsync(id);
}
