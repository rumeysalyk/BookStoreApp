using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class BookController:Controller
    {
        public IActionResult Index()
        {
          return View();
        }

        public IActionResult Create()
        {

          return View();
        }
        public IActionResult List()
        {
            
          return View();
        }

    }
}