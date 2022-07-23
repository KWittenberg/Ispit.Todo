namespace Ispit.Todo.Services.Interface;

public interface IApplicationUserService
{
    Task<ApplicationUser?> CreateUserAsync(ApplicationUserBinding model, string role);
    Task<ApplicationUserViewModel?> CreateApiUserAsync(ApplicationUserBinding model, string role);
}