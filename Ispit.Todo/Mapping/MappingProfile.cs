namespace Ispit.Todo.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // ApplicationUser
        CreateMap<ApplicationUser, ApplicationUserViewModel>();

        // ToDoList
        CreateMap<ToDoListBinding, ToDoList>();
        CreateMap<ToDoListUpdateBinding, ToDoList>();
        CreateMap<ToDoList, ToDoListViewModel>();
        CreateMap<ToDoListViewModel, ToDoListUpdateBinding>();

        CreateMap<ToDoListBinding, ToDoList>();
        CreateMap<ToDoListUpdateBinding, ToDoList>();
        CreateMap<ToDoList, ToDoListViewModel>();
        CreateMap<ToDoListViewModel, ToDoListUpdateBinding>();

        // Task
        CreateMap<TaskBinding, Ispit.Todo.Models.Dbo.Task>();
        CreateMap<Ispit.Todo.Models.Dbo.Task, TaskViewModel>();
    }
}