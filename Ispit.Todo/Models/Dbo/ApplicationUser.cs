namespace Ispit.Todo.Models.Dbo;

public class ApplicationUser : IdentityUser
{
    //public string FirstName { get; set; }
    //public string LastName { get; set; }

    public ICollection<ToDoList> ToDoList { get; set; }
}