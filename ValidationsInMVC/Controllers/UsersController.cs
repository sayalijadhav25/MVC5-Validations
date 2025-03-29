using System.Linq;
using System.Web.Mvc;
using ValidationsInMVC.Models;
using ValidationsInMVC.Models.Entities;


namespace ValidationsInMVC.Controllers
{
    public class UsersController : Controller
    {
        UserDbContext _dbContext;

        public UsersController()
        {
            _dbContext = new UserDbContext();
        }

        // GET: Users
        [HttpGet]
        public ActionResult Index()
        {
            // need to project List<User> => List<UserModel>
            var users = _dbContext.Users.ToList().
                Select(u => new UserModel()
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    DateOfBirth = u.DateOfBirth,
                    Email = u.Email,
                    Password = u.Password,
                    FacebookProfileURL = u.FacebookProfileURL
                });
            return View(users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //bool isEmailExists = _dbContext.Users.Any(u => 
                    //u.Email == user.Email);
                    //if (isEmailExists)
                    //{
                    //    ModelState.AddModelError("Email", "EMail already exists/ registered");
                    //    return View();
                    //}

                    // UserModel => User

                    User dbUser = new User()
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Age = user.Age,
                        DateOfBirth = user.DateOfBirth,
                        Email = user.Email,
                        Password = user.Password,
                        FacebookProfileURL = user.FacebookProfileURL
                    };

                    _dbContext.Users.Add(dbUser);
                    _dbContext.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

    }
}