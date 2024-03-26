using App_Data_ClassLib.Models;
using ASMC4.Models;
using DuAnC4.AllRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASMC4.Controllers
{
    public class UserController : Controller
    {
        ASMC4Context _context;
        AllRepos<User> Repos;
        DbSet<User> users;
        public UserController()
        {
            _context = new ASMC4Context();
            users = _context.User;
            Repos = new AllRepos<User>(_context.User, _context);
        }
        public IActionResult Index()
        {
            var userData = Repos.GetAll();
            return View(userData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            user.UserID = Guid.NewGuid(); // Tạo một GUID mới cho trường "UserID"
            Repos.CreateObj(user); // Lưu đối tượng user vào cơ sở dữ liệu
            return View(user);
        }
        public IActionResult Edit(Guid id)
        {
            var updateUser = Repos.GetByID(id);
            return View(updateUser);
        }
        public IActionResult EditUser(User user)
        {
            Repos.UpdateObj(user);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            Repos.DeleteObj(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            var getUser = Repos.GetByID(id);
            return View(getUser);
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(string UserName,string Password)
        {
            var users = Repos.GetAll().FirstOrDefault(p => p.TenNguoiDung == UserName && p.Matkhau == Password);
            if (users != null)
            {
				TempData["Login"] = UserName;
				return RedirectToAction("Index", "Home");

			}
            else return Content("Đăng Nhập Thất Bại");
        }

    }
}
