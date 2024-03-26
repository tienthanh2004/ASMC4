using App_Data_ClassLib.Models;
using DuAnC4.AllRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App_Data_ClassLib.Models;

namespace ASMC4.Controllers
{
    public class SanPhamController : Controller
    {
        ASMC4Context _context;
        AllRepos<SanPham> Repos;
        DbSet<SanPham> sanPhams;

        public SanPhamController()
        {
            _context = new ASMC4Context();
            sanPhams = _context.SanPhams;
            Repos = new AllRepos<SanPham>(_context.SanPhams, _context);
        }

        public IActionResult Index()
        {
			var lstSanPham = Repos.GetAll();
            return View(lstSanPham);
        }
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(SanPham sanPham)
		{
			sanPham.IDSP = Guid.NewGuid(); 
			Repos.CreateObj(sanPham); 
			return View(sanPham);
		}

		public IActionResult Edit(Guid id)
		{
			var updateSP = Repos.GetByID(id);
			return View(updateSP);
		}

		public IActionResult EditSanPham(SanPham sanPham)
		{
			Repos.UpdateObj(sanPham);
			return RedirectToAction("Index");
		}
		public IActionResult Delete(Guid id)
		{
			Repos.DeleteObj(id);
			return RedirectToAction("Index");
		}
		public IActionResult Details(Guid id)
		{
			var getSanPham = Repos.GetByID(id);
			return View(getSanPham);
		}
	}
}
