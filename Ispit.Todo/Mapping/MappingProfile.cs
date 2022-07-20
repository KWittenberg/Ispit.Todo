namespace Ispit.Todo.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<ApplicationUser, ApplicationUserViewModel>();

        CreateMap<TaskBinding, Ispit.Todo.Models.Dbo.Task>();
        CreateMap<Ispit.Todo.Models.Dbo.Task, TaskViewModel>();

        CreateMap<ToDoListBinding, ToDoList>();
        CreateMap<ToDoList, ToDoListViewModel>();
    }
}