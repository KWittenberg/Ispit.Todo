namespace Ispit.Todo.Models.Dbo;

public class Task : TaskBase, IEntityBase
{
    [Key]
    public int Id { get; set; }
    public ToDoList ToDoList { get; set; }
    public DateTime Created { get; set; }
}