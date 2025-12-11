using FluentValidation;
public class CreateTodoValidator : AbstractValidator<CreateTodoCommand>
{
    public CreateTodoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MinimumLength(3);
    }
}
