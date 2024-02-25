using Day2Homework3.DataAccess.Abstracts;
using Day2Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework3.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {

            Course course1 = new();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course1.InstructorDescription = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip ,döküman ve duyurularını buradan yapacağız.";
            course1.InstructorName = "Engin Demirog";
            course1.Price = "ÜCRETSİZ";

            Course course2 = new();
            course2.Id = 2;
            course2.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.InstructorDescription = "2 ay sürecek Yazılım Geliştiri Yetiştirme Kampımızın takip , döküman ve duyurularını buradan yapacağız.";
            course2.InstructorName = "Engin Demirog";
            course2.Price = "ÜCRETSİZ";

            Course course3 = new();
            course3.Id = 3;
            course3.Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course3.InstructorDescription = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip , döküman ve duyurularını buradan yapacağız.";
            course3.InstructorName = "Halit Enes Kalaycı";
            course3.Price = "ÜCRETSİZ";

            Course course4 = new();
            course4.Id = 4;
            course4.Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course4.InstructorDescription = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip , döküman ve duyurularını buradan yapacağız.";
            course4.InstructorName = "Engin Demirog";
            course4.Price = "ÜCRETSİZ";

            Course course5 = new();
            course5.Id = 5;
            course5.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course5.InstructorDescription = "1.5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip , döküman ve duyurularını buradan yapacağız.";
            course5.InstructorName = "Engin Demirog";
            course5.Price = "ÜCRETSİZ";

            Course course6 = new();
            course6.Id = 6;
            course6.Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course6.InstructorDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip , döküman ve duyurularını buradan yapacağız.";
            course6.InstructorName = "Engin Demirog";
            course6.Price = "ÜCRETSİZ";

            Course course7 = new();
            course7.Id = 7;
            course7.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course7.InstructorDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip , döküman ve duyurularını buradan yapacağız.";
            course7.InstructorName = "Engin Demirog"; 
            course7.Price = "ÜCRETSİZ";

            Course course8 = new();
            course8.Id = 8;
            course8.Name = "Programlamaya Giriş için Temel Kurs";
            course8.InstructorDescription = "PYTHON,JAVA,C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.";
            course8.InstructorName = "Engin Demirog";
            course8.Price = "ÜCRETSİZ";

            _courses= new List<Course> {course1,course2,course3,course4,course5,course6,course7,course8 };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Console.WriteLine("Kurs silme işlemi");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Kurs güncelleme işlemi");
        }
    }
}
