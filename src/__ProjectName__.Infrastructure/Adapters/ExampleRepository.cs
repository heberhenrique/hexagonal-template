
using System;
using System.Threading.Tasks;
using __ProjectName__.Application.Ports.Output;

namespace __ProjectName__.Infrastructure.Adapters;

public class ExampleRepository : IExampleRepository
{
    public Task<string> GetAsync(Guid id)
        => Task.FromResult($"Example {id}");
}
