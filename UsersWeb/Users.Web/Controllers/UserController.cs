using System.Web.Mvc;
using Users.Web.Models;
using BusinessLogic;
using DataAccess;
using Users.Web.Controllers.Classes;
namespace Users.Web.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository = new UserRepository();
        //Users's List
        public ActionResult Index()
        {
            return View(userRepository.GetData());
        }

        //Edit user
        [HttpGet]
        public ActionResult Edit(int? id = null)
        {
            if (id == null || id == 0) return RedirectToAction("Index");
            UserViewModel userViewModel = userRepository.GetUserByid((int)id).ParseSingleUser();
            return View(userViewModel);
        }
        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                userRepository.EditUserFromList(userViewModel.Id, userViewModel.Username, userViewModel.Email, userViewModel.Description, userViewModel.City, userViewModel.Street, (User.Category)userViewModel.CategoryId);
                return RedirectToAction("Index");
            }
            return View(userViewModel);
        }

        //Add user
        [HttpGet]
        public ActionResult Add()
        {
            UserViewModel userViewModel = new UserViewModel();
            return View(userViewModel);
        }
        [HttpPost]
        public ActionResult Add(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                userRepository.AddUser(userViewModel.Username, userViewModel.Email, userViewModel.Description, userViewModel.City, userViewModel.Street, (User.Category)userViewModel.CategoryId);
                return RedirectToAction("Index");
            }
            return View(userViewModel);
        }

        //Delete user
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if ((id == null) || (id == 0)) return RedirectToAction("Index");
            UserViewModel userViewModel = userRepository.GetUserByid((int)id).ParseSingleUser();
            return View(userViewModel);
        }
        [HttpPost]
        public ActionResult Delete(UserViewModel userViewModel)
        {
            userRepository.Delete(userViewModel.Id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Details(int? id)
        {
            if ((id == null) || (id == 0)) return RedirectToAction("Index");
            UserViewModel userViewModel = userRepository.GetUserByid((int)id).ParseSingleUser();
            if (ModelState.IsValid)
            {
                return View(userViewModel);
            }

            return RedirectToAction("Index");
        }
    }
}