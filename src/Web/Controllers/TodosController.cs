using Microsoft.AspNetCore.Mvc;
using MediatR;

[ApiController]
[Route(""api/[controller]"")]
public class TodosController : ControllerBase
{
    private readonly IMediator _mediator;
    public TodosController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> Create(CreateTodoCommand cmd)
    {
        return Ok(new { id = 1 });
    }
}
