namespace Ispit.Todo.Models.Dbo;

public class ApplicationUser : IdentityUser
{
    //public string FirstName { get; set; }
    //public string LastName { get; set; }

    public ICollection<ToDoList> ToDoList { get; set; }



    //public string Firstname { get; set; }
    //public string Lastname { get; set; }
    //public DateTime DOB { get; set; }
    //public ICollection<Adress> Adress { get; set; }
    //public ICollection<ShoppingCart> ShoppingCart { get; set; }
}