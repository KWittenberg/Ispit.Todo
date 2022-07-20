namespace Ispit.Todo.Models.Dbo;

public class ToDoList : ToDoListBase, IEntityBase
{
    [Key]
    public int Id { get; set; }
    public ICollection<Task> Task { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public DateTime Created { get; set; }
}