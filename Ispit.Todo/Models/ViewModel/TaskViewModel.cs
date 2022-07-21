namespace Ispit.Todo.Models.ViewModel;

public class TaskViewModel : TaskBase
{
    public int Id { get; set; }
    public ToDoListViewModel ToDoList { get; set; }
    public int ToDoListId { get; set; }
    public DateTime Created { get; set; }
}