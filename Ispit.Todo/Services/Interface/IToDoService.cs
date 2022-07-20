namespace Ispit.Todo.Services.Interface;

public interface IToDoService
{
    Task<TaskViewModel?> ChangeTaskStatus(int taskId, bool status);
    Task<TaskViewModel?> CreateTask(TaskBinding model);
    Task<ToDoListViewModel?> CreateToDoList(ToDoListBinding model);
    Task<TaskViewModel?> GetTask(int taskId);
    Task<List<TaskViewModel>> GetTasks(int todoListId);
    Task<List<ToDoListViewModel>> GetToDoList();
}