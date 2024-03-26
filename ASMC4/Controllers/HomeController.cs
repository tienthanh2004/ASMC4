using App_Data_ClassLib.Models;
using ASMC4.Models;
using DuAnC4.AllRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NuGet.Protocol.Plugins;
using System.Diagnostics;

namespace ASMC4.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		AllRepos<User> Repos;


		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult DangKy()
		{
			return View();
		}
		[HttpPost]
		public IActionResult DangKy(User user)
		{
			user.ChucVu = "User"; // Đặt trường "ChucVu" là "User"
			user.UserID = Guid.NewGuid();
			Repos.CreateObj(user);
			return View(user);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
