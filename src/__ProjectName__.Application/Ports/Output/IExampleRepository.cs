
using System;
using System.Threading.Tasks;

namespace __ProjectName__.Application.Ports.Output;
public interface IExampleRepository
{
    Task<string> GetAsync(Guid id);
}
