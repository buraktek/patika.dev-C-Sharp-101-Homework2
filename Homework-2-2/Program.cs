using System;
using System.Collections.Generic;

namespace Homework_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[20];

            Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                double deger;
                if (double.TryParse(Console.ReadLine(), out deger))
                {
                    sayilar[i] = deger;
                }
            }
            Array.Sort(sayilar);


            double buyuk_uc_sayi_toplami = 0, kucuk_uc_sayi_toplami = 0;

            Console.WriteLine(Environment.NewLine + "En küçük 3 sayı: {0} {1} {2}", sayilar[0], sayilar[1], sayilar[2]);
            kucuk_uc_sayi_toplami = sayilar[0] + sayilar[1] + sayilar[2];
            Console.WriteLine("En küçük 3 sayı Toplamı: {0}   Ortalaması: {1}", kucuk_uc_sayi_toplami, (kucuk_uc_sayi_toplami / 3).ToString("F2"));

            Console.WriteLine(Environment.NewLine + "En büyük 3 sayı: {0} {1} {2}", sayilar[19], sayilar[18], sayilar[17]);
            buyuk_uc_sayi_toplami = sayilar[19] + sayilar[18] + sayilar[17];
            Console.WriteLine("En büyük 3 sayı Toplamı: {0}   Ortalaması: {1}", buyuk_uc_sayi_toplami, (buyuk_uc_sayi_toplami / 3).ToString("F2"));
        }
    }
}
