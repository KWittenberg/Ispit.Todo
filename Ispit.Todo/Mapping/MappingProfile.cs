namespace Ispit.Todo.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // ApplicationUser
        CreateMap<ApplicationUser, ApplicationUserViewModel>();
        CreateMap<ApplicationUserBinding, ApplicationUser>()
            .ForMember(dst => dst.UserName, opts => opts.MapFrom(src => src.Email))
            .ForMember(dst => dst.EmailConfirmed, opts => opts.MapFrom(src => true));



        // ToDoList
        CreateMap<ToDoListBinding, ToDoList>();
        CreateMap<ToDoListUpdateBinding, ToDoList>();
        CreateMap<ToDoList, ToDoListViewModel>();
        CreateMap<ToDoListViewModel, ToDoListUpdateBinding>();

        // Task
        CreateMap<TaskBinding, Ispit.Todo.Models.Dbo.Task>();
        CreateMap<TaskUpdateBinding, Ispit.Todo.Models.Dbo.Task>();
        CreateMap<Ispit.Todo.Models.Dbo.Task, TaskViewModel>();
        CreateMap<TaskViewModel, TaskUpdateBinding>();
    }
}