namespace Domain.Entities;

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsDone { get; set; }
}
