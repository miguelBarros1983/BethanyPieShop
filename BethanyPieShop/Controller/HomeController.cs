
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanyPieShop.Controller
{
    using System.Linq;

    using BethanyPieShop.Models;
    using BethanyPieShop.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using Controller = Microsoft.AspNetCore.Mvc.Controller;

    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Pie overview";

            IOrderedEnumerable<Pie> pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany´s Pie Shop",
                Pies = pies.ToList() 
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            Pie pie = _pieRepository.GetPieById(id);

            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
