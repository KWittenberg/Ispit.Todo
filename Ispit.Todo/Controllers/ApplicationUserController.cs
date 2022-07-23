namespace Ispit.Todo.Controllers;

public class ApplicationUserController : Controller
{
    private readonly IApplicationUserService userService;
    private readonly SignInManager<ApplicationUser> signInManager;

    public ApplicationUserController(IApplicationUserService userService, SignInManager<ApplicationUser> signInManager)
    {
        this.userService = userService;
        this.signInManager = signInManager;
    }

    public IActionResult Registration()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Registration(ApplicationUserBinding model)
    {
        var result = await userService.CreateUserAsync(model, Roles.User);
        if (result != null)
        {
            await signInManager.SignInAsync(result, true);
            return RedirectToAction("Index", "Home");
        }
        return View();
    }
}