﻿// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

Console.WriteLine("Hello, World!");
string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase 
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition
if(isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Nuray");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
for(int i =0;i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}
Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 vs";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "Java 17...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for(int i = 0;i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdenty = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer1.Id = 2;
customer1.NationalIdenty = "56478965412";
customer1.FirstName = "Özgür";
customer1.LastName = "Atılgan";
customer1.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer2.Id = 3;
customer2.FirstName = "Kodlama.io";
customer2.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer2.Id = 4;
customer2.FirstName = "Abc";
customer2.CustomerNumber = "654779";
customer3.TaxNumber = "12345678985";

// Value types --> int,bool,double
// Reference types --> array,class , interface...

//                              101         102         103         104
BaseCustomer[] customers = { customer1, customer2 , customer3 , customer4};

//Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

