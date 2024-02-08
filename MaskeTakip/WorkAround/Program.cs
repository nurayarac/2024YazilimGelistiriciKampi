using System;

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