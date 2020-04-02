using System.Collections.Generic;
using System.Linq;
using BookStoreApp.Models;

namespace BookStoreApp.Data
{
public class CategoryRepository
    {
        private static List<Category> categories = null;


        static CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category(){Id=1,Name="Felsefe"},
                new Category(){Id=2,Name="Polisiye"},
                new Category(){Id=3,Name="Psikoloji"},
                new Category(){Id=4,Name="Sosyoloji"},
                new Category(){Id=5,Name="Tarih"}

            };
        }



        public static List<Category> Categories{
            get{
                return categories;
            }
        }

        public static void AddCategory(Category item){
            categories.Add(item);
        }

        public static Category GetById(int id)
        {
            return categories.FirstOrDefault(i => i.Id == id);
        }

    }
}