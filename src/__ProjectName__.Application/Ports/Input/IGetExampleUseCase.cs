
using System;
using System.Threading.Tasks;

namespace __ProjectName__.Application.Ports.Input;

public interface IGetExampleUseCase
{
    Task<string> ExecuteAsync(Guid id);
}
