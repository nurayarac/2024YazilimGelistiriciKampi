using Day2Homework3.DataAccess.Abstracts;
using Day2Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework3.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal() {
            Category category1 = new();
            category1.Id = 1;
            category1.CategoryName = "Tümü";

            Category category2 = new();
            category2.Id = 2;
            category2.CategoryName = "Programlama (8)";

            _categories = new List<Category> {category1 , category2};
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Console.WriteLine("Kategori silme");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Kategori güncelleme");
        }
    }
}
