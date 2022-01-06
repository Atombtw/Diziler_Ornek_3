using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Ornek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();

            Console.WriteLine("Gireceğiniz şehir sayısını giriniz : ");
            a.şehir = Convert.ToInt32(Console.ReadLine());
            a.sehirler = new string[a.şehir];

            for (int i = 0; i < a.sehirler.Length; i++)
            {
                Console.Write("{0}. Şehri Girin : ", i + 1);
                a.sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.Write("Aranacak şehri girin : ");
            a.arananSehir = Console.ReadLine();

            for (int i = 0; i < a.sehirler.Length; i++)
            {
                if (a.sehirler[i] == a.arananSehir)
                {
                    a.sayac++;
                }
            }

            if (a.sayac == 0)
            {
                Console.WriteLine("Şehir bulunamadı.");
            }
            else
            {
                Console.WriteLine("Dizi içinde {0} adet {1} şehrine ait kayıt mevcut ", a.sayac, a.arananSehir);
            }
            Console.ReadKey();
        }
    }
}