using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Films_MVC.Controllers
{

    public class FilmController : Controller
    {
        FilmContext db;
        public FilmController(FilmContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Film> films = await Task.Run(() => db.Films);
            ViewBag.Films = films;
            return View("Index");
        }
    }

}