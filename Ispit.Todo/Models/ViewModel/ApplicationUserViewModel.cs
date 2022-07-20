namespace Ispit.Todo.Models.ViewModel;

public class ApplicationUserViewModel
{
    public string Id { get; set; }
    public List<ToDoListViewModel> ToDoList { get; set; }
}