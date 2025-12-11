using MediatR;
public record CreateTodoCommand(string Title) : IRequest<int>;
