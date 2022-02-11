using claimsHandling.Data;
using claimsHandling.Models;
using Microsoft.AspNetCore.Mvc;


namespace claimsHandling.Controllers
{
    public class UsersLoginController : Controller
    {

        private readonly InterviewContext _context;
        public UsersLoginController(InterviewContext context)
        {
            _context = context;
        }
      
        public IActionResult UsersLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UsersLogin(User obj)
        {
            try
            {
                if (_context.Users.Any(a => a.UserName == obj.UserName && a.Password == obj.Password && a.Active == true))
                {
                    TempData["user"] = obj.UserName;
                    return RedirectToAction("LossTypeData", new { username = obj.UserName, password = obj.Password });
                }

                else
                {
                    ViewBag.error = "!!Please Enter valid login credentials.";
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ViewBag.error = "!!There is some error.";
            }
            return View();
        }
        public IActionResult LossTypeData(string username, string password)
        {
            if(username == null || password == null)
                return RedirectToAction("UsersLogin");
            List<claimsHandling.Models.LossType> lossTypes = _context.LossTypes.ToList();
            return View(lossTypes);
        }
    }
}
