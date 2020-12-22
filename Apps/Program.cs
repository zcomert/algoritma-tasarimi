using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        public static int MutlakDeger(int n)
        {
            if (n < 0)
                n = -n;
            return n;
        }
        #region Ornekler
        private static void TekCiftSayiOrnegi()
        {
            // ekran cikti verir. 
            Console.WriteLine("Bir sayi giriniz: ");

            // klavyeden girilen bir sayiyi saiy degiskenin de saklar. 
            int sayi =
                Convert.ToInt32(Console.ReadLine());

            // fonksiyon sonucunu sonuc degiskeninde saklar. 
            bool sonuc = TekMi(sayi);

            // Sonucu ekrana yazar. 
            Console.WriteLine($"Tek mi? {sonuc}");

            // Klavyeden bir tusa basılması bekler. 
            Console.ReadKey();
        }
        /// <summary>
        /// Parametre olarak aldgini sayinin tek mi yoksa cift mi oldugunu kontrol eder.
        /// </summary>
        /// <param name="n">Sayi temsil eder.</param>
        /// <returns>true/false</returns>
        private static bool TekMi(int n)
        {
            // Kosul ifadesini degerlendirir. Kosul dogru if blogu 
            // aksi durumda else blogu calisr. 
            if (n % 2 == 1)
                return true;
            else
                return false;
        }
        private static void NKadarYazdir(int n=5)
        {
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i,-3}");
            }
            Console.WriteLine();
        }
        private static void MutlakDegerOrnegi()
        {
            int n = Convert
                .ToInt32(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(-n);
            }

            Console.ReadKey();
        }
        private static void KokBulma(float a, float b, float c)
        {
            float delta = b * b - (4 * a * c);
            float kokDelta = (float)Math.Sqrt(delta);


            if (delta > 0)
            {
                Console.WriteLine("İki farklı kök vardır. ");

                Console.Write("Birinci kök : ");
                float kok1 = (-b + kokDelta) / (2 * a);
                Console.WriteLine(kok1);

                Console.Write("İkinci kök : ");
                float kok2 = (-b - kokDelta) / (2 * a);
                Console.WriteLine(kok2);
                Console.ReadLine();
            }
            else if (delta == 0)
            {
                Console.Write("Bir çift kök vardır. ");
                float kok = -b / 2 * a;
                Console.WriteLine(kok);

            }
            else
            {
                Console.WriteLine("Reel kök yoktur. ");
            }
            Console.ReadLine();
        }

        #endregion
    }

}   
