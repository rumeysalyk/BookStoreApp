using System.Linq;
using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers{
    public class HomeController : Controller
    {

        
        [HttpGet]
        public IActionResult Index(int? id)
        {         
          //BookCategory bookCategory = new BookCategory();
          //bookCategory.Categories=CategoryRepository.Categories;
          //bookCategory.Books=BookRepository.Books;

          var books = BookRepository.Books;

          if(id!=null)
          {
            books = books.Where(i=>i.CategoryId == id ).ToList();
          }

          return View(books);
        }
        
        public IActionResult Contact()
        {
          
          return View();
        }
        public IActionResult Details(int id){

          //BookCategory bookCategory = new BookCategory();
          //bookCategory.Categories = CategoryRepository.Categories;
          //bookCategory.book = BookRepository.GetById(id);


          return View(BookRepository.GetById(id));
        }

    }
}