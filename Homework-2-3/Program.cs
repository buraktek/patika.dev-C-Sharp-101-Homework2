using System;

namespace Homework_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sesli harflerinin taranmasını istediğiniz cümleyi yazınız");
            string data = Console.ReadLine();
            string sesli = "aeıioöuü";
            char[] characters = new char[100];
            int index = 0;
            string sesli_harfler = "";
            foreach (char a in data)
            {
                if (sesli.Contains(a))
                {
                    characters[index] = a;
                    sesli_harfler += a + " ";
                    index++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Girilen cümledeki sesli harfler: " + sesli_harfler);
        }
    }
}
