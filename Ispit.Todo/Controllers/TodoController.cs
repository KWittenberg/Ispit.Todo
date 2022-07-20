namespace Ispit.Todo.Controllers;

[Authorize]
public class ToDoController : Controller
{
    private readonly IToDoService toDoService;
    private readonly UserManager<ApplicationUser> UserManager;

    public ToDoController(IToDoService toDoService, UserManager<ApplicationUser> userManager)
    {
        this.toDoService = toDoService;
        UserManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var todoLists = await toDoService.GetToDoList();
        return View(todoLists);
    }

    /// <summary>
    /// Details
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<IActionResult> Details(int id)
    {
        ViewBag.ToDoListId = id;
        CreateTaskViewModel model = new CreateTaskViewModel();
        model.Tasks = await toDoService.GetTasks(id);
        model.ToListId = id;
        return View(model);
    }



    /// <summary>
    /// CreateToDoList
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> CreateToDoList()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateToDoList(ToDoListBinding model)
    {
        var userId = UserManager.GetUserId(User);
        model.ApplicationUserId = userId;
        var todoLists = await toDoService.CreateToDoList(model);
        return RedirectToAction("Index");
    }


    /// <summary>
    /// CreateTask
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> CreateTask(int id)
    {
        return View(new TaskBinding { ToDoListId = id });
    }
    [HttpPost]
    public async Task<IActionResult> CreateTask(TaskBinding model)
    {
        var task = await toDoService.CreateTask(model);
        return RedirectToAction("Details", new { id = task.ToDoList.Id });
    }
    
    /// <summary>
    /// ChangeTaskStatus
    /// </summary>
    /// <param name="id"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    public async Task<IActionResult> ChangeTaskStatus(int id, bool status)
    {
        var task = await toDoService.ChangeTaskStatus(id, status);
        return RedirectToAction("Details", new { id = task.ToDoList.Id });
    }
}