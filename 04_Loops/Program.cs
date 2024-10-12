using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}

            //for (int i = 0; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Ekrana kaç defa, Yaşasın Cumhuriyet yazdırmak istersiniz : ");
            //int finisValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i < finisValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }      
            //}
            //Console.WriteLine(count);

            //int bactarium = 1;
            //for (int i = 0; i < 24; i++)
            //{
            //    bactarium *= 2;
            //    Console.WriteLine(i + " Saat " + "Sonunda bacterium'dan gelen değer : " + bactarium);
            //}
            #endregion

            #region While Döngüsü
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if ( i% 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion

            #region Örnek Sınav Sorusu
            // Klavyeden girilen 3 basamaklı sayının basamaklarını hesaplayan kodu yazınız..

            Console.Write("Lütfen 3 basamaklı bir sayı giriniz : ");
            string girilensayi = Console.ReadLine();

            if (girilensayi.Length == 3)
            {
                // Karakterleri tam sayıya dönüştür ve toplamını hesapla
                int sayi = (girilensayi[0] - '0') + (girilensayi[1] - '0') + (girilensayi[2] - '0');
                Console.Write(sayi);
            }
            else
            {
                Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz");
            }


            #endregion

            Console.Read();
        }
    }
}
