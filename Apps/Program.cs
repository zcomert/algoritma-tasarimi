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
        

        
    }
}
