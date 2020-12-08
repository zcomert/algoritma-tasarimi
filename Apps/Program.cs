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
            int[] X = new int[] { -5, 10, -20, 30, -23 };
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = MutlakDeger(X[i]);
                Console.WriteLine(X[i]);
            }
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
        #endregion
    }
}
