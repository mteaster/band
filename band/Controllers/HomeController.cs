using System.Linq;
using System.Web.Mvc;
using band.Models;
using band.Stuff;

namespace band.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
<<<<<<< HEAD
            return View();
        }
=======
            ViewBag.Message = "Login or Create and Join a Band";
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39

        // TEST ONLY

        // The old "About" page
        public ActionResult Accounts()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult UserList()
        {
<<<<<<< HEAD
            using (DatabaseContext database = new DatabaseContext())
            {
                return PartialView("_UserListPartial", database.UserProfiles.ToList());
            }
        }
=======
            ViewBag.Message = "About This App.";
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39

        [ChildActionOnly]
        public ActionResult BandList()
        {
            return PartialView("_BandListPartial", BandUtil.BandModels(true));
        }

        // This is where I play around with stuff
        public ActionResult Test()
        {
<<<<<<< HEAD
            ViewBag.StatusMessage = "what am i doing here";
            
            //WebSecurity.CreateUserAndAccount("admin", "password", new { DisplayName = "admin" });
            //Roles.CreateRole("Administrator");
            //Roles.AddUserToRole("admin", "Administrator");
=======
            ViewBag.Message = "Contact the CREATORS!!!.";
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39

            return View();
        }
    }
}
