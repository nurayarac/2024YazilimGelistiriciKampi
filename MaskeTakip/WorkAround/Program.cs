using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SelamVer(isim : "Nuray");
            SelamVer(isim: "derya");
            SelamVer(isim: "zehra");
            SelamVer();
            int sonuc = Topla(3,5);
            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdenty = 123;


            Person person2 = new Person();
            person2.FirstName = "Derya";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer(string isim = "İsimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1 , int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc.ToString());
            return sonuc;
        }
    }
    
}
