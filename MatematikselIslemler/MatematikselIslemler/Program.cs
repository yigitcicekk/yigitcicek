using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
        YenidenIslemYap:
            M.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. Sayı değerini giriniz");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayı değerini giriniz");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: // Toplama
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2: // Çıkartma
                    sonuc = M.cıkartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3: // Bölme
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                case 4: // Çarpma
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Belirtmiş Olduğunuz değer liste içerisinde bulunamadı");
                    Console.WriteLine("Lütfen yeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;

            }
            Console.WriteLine("Yeni İşlem Yapmak İstiyo musunuz ? [E/H] ");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}

