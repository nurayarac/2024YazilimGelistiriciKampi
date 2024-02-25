
using Day2Homework3.Business;
using Day2Homework3.DataAccess.Concretes;
using Day2Homework3.Entities;

CategoryManager categoryManager = new(new CategoryDal());

List<Category> categories = categoryManager.GetAll();
for(int i=0; i<categories.Count; i++)
{
    Console.WriteLine("Kategori adı:" + categories[i].CategoryName);
}


CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine("Kursun ismi:" + courses[i].Name);
    Console.WriteLine("Kursun ücreti:" + courses[i].Price);
}

courseManager.Delete(courses[courses.Count - 1]);
courseManager.Update(courses[0]);

InstructorManager instructorManager = new(new InstructorDal());

List<Instructor> instructors = instructorManager.GetAll();
for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine("Eğitmen:" + instructors[i].FirstName + " " + instructors[i].LastName);
}