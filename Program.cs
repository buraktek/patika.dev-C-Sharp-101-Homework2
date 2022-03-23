using System;
using System.Collections.Generic;

namespace Homework_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> asal_sayilar = new List<int>();
            List<int> asal_olmayan_sayilar = new List<int>();

            Console.WriteLine("Lütfen 20 adet pozitif tam sayı giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                int deger;
                if (int.TryParse(Console.ReadLine(), out deger))
                {
                    if (deger > 0)
                    {
                        if (asal_sayi_kontrol(deger))
                            asal_sayilar.Add(deger);
                        else
                            asal_olmayan_sayilar.Add(deger);
                        continue;
                    }
                }
                Console.WriteLine("Geçersiz giriş yapıldı, lütfen pozitif tam sayı giriniz: ");
                i--;
            }

            asal_sayilar.Sort();
            asal_olmayan_sayilar.Sort();
            double asal_ort = 0, asal_olmayanlarin_ort = 0;
            Console.WriteLine(Environment.NewLine + "Girilen asal sayılar:");
            foreach (int sayi in asal_sayilar)
            {
                Console.Write(sayi + " ");
                asal_ort += sayi;
            }
            asal_ort /= asal_sayilar.Count;
            Console.WriteLine(Environment.NewLine + "Adeti: " + asal_sayilar.Count + "  Ortalaması: " + asal_ort.ToString("F2"));


            Console.WriteLine(Environment.NewLine + "Girilen asal olmayan sayılar:");
            foreach (int sayi in asal_olmayan_sayilar)
            {
                Console.Write(sayi + " ");
                asal_olmayanlarin_ort += sayi;
            }
            asal_olmayanlarin_ort /= asal_olmayan_sayilar.Count;
            Console.WriteLine(Environment.NewLine + "Adeti :" + asal_olmayan_sayilar.Count + "  Ortalaması: " + asal_olmayanlarin_ort.ToString("F2"));
        }

        static bool asal_sayi_kontrol(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }
    }
}
