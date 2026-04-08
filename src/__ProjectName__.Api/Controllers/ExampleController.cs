using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using __ProjectName__.Application.Ports.Input;

namespace __ProjectName__.Api.Controllers;

[ApiController]
[Route("api/examples")]
public class ExampleController : ControllerBase
{
    private readonly IGetExampleUseCase _useCase;

    public ExampleController(IGetExampleUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
        => Ok(await _useCase.ExecuteAsync(id));
}
