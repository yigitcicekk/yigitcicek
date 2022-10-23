using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not sistemine hoşgeldiniz");

            Console.Write("İsim Soyisim :");
            string isimsoyisim = Console.ReadLine();

            Console.Write("Not 1 giriniz :");
            string notStr1 = Console.ReadLine();

            Console.Write("Not 2 giriniz :");
            string notStr2 = Console.ReadLine();

            Console.Write("Not 3 giriniz :");
            string notStr3 = Console.ReadLine();

            decimal not1 = Convert.ToDecimal(notStr1);
            decimal not2 = Convert.ToDecimal(notStr2);
            decimal not3 = Convert.ToDecimal(notStr3);

            decimal toplam = not1 + not2 + not3;
            decimal ortalama = toplam / 3;

            Console.WriteLine("Ortalama :" + ortalama);

            if (ortalama < 45)
            {
                Console.WriteLine(isimsoyisim + " Kaldınız");
            }
            else if (ortalama == 45 || ortalama < 70)
            {
                Console.WriteLine(isimsoyisim + " Orta ile geçtiniz");
            }
            else if (ortalama == 70 || ortalama < 90)
            {
                Console.WriteLine(isimsoyisim + " İyi ile geçtiniz");
            }
            else if (ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine(isimsoyisim + " Başarılı Tebrikler");
            }
            else if (ortalama > 100)
            {
                Console.WriteLine(" Notlarınızı Kontrol ediniz");
            }
            Console.ReadLine();
        }
    }
}

