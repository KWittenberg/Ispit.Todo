namespace Ispit.Todo.Controllers;

public class ApplicationUserController : Controller
{
    private readonly IApplicationUserService userService;
    private readonly SignInManager<ApplicationUser> signInManager;
    private readonly UserManager<ApplicationUser> userManager;

    public ApplicationUserController(IApplicationUserService userService, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
    {
        this.userService = userService;
        this.signInManager = signInManager;
        this.userManager = userManager;
    }


    /// <summary>
    /// Register
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(ApplicationUserBinding model)
    {
        var result = await userService.CreateUserAsync(model, Roles.User);
        if (result != null)
        {
            await signInManager.SignInAsync(result, true);
            TempData["success"] = "User Register successfully";
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    /// <summary>
    /// Login
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(ApplicationUserBinding model)
    {
        if (ModelState.IsValid)
        {
            var result = await this.signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                TempData["success"] = "User Login successfully";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["error"] = "Invalid Login Attempt !!!";
                return View(model);
            }
        }
        return View();
    }
}