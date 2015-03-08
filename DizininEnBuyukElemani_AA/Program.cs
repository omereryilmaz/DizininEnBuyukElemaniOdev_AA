using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizininEnBuyukElemani_AA
{
    class Program
    {
        public const int DIFF_NUMBERS = 10000;
        public const int TOTAL_NUMBERS = 1000000;
        
        static void Main(string[] args)
        {
            int[] numbers = new int[DIFF_NUMBERS + 1];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = 0;

            Random r = new Random();

            // Sayi uret ve diziye aktar
            for (int i = 0; i < DIFF_NUMBERS; i++)
            {
                numbers[i] = r.Next(TOTAL_NUMBERS);
            }

            // Olusturulan dizi elemanlarını ekrana bas
            for (int i = 0; i < DIFF_NUMBERS; i++)
                Console.WriteLine(i  + ": " + numbers[i]);

            EnBuyukSayiBul(numbers); //dizinin en buyuk elemanini bulan fonksiyon

            Console.Write("Kacinci Eleman Bulunsun? :");
            int a = int.Parse(Console.ReadLine());
            elemanBul(a,numbers);
            Console.ReadKey();

            
        }

        private static void elemanBul(int a, int[] numbers)
        {
            int gecici = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j= 0; j< i; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        gecici = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = gecici;
                    }
                }
            }
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(i + ": " + numbers[i]);
            if (a >= 0 && a <= numbers.Length)
            {
                Console.WriteLine(a + ".eleman :" + numbers[a]);
            }
        }

        

        private static void EnBuyukSayiBul(int[] dizi)
        {
            int enBuyuk=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (enBuyuk < dizi[i])
                    enBuyuk = dizi[i];

            }
            Console.WriteLine("En buyuk sayi : " + enBuyuk);
            
        }

       
    }
}
