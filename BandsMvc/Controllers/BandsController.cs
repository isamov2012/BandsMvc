using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService = new DataService();

        [HttpGet("/")]
        [HttpGet("bands/index")]
        public IActionResult Index()
        {
            Band[] bands = dataService.GetAllBands();
            return View(bands);
        }

        [HttpGet("/details/{Id}")]
        public IActionResult Details(int Id)
        {
            Band[] bands = dataService.GetAllBands();
            var q = bands
                    .First(x=>x.Id == Id);
            return View(q);
        }
    }
}
