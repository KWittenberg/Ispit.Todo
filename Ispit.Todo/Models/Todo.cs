namespace Ispit.Todo.Models;

public class Todo
{
    public int Id { get; set; }
    public string Napraviti { get; set; }
    public bool Status { get; set; }
    public DateTime Datum { get; set; }
}