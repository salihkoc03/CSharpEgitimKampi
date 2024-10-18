using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mor";

            //Console.WriteLine(colors[1]);

            //string[] city = new string[5];
            //city[0] = "Ankara";
            //city[1] = "Adana";
            //city[2] = "İstanbul";
            //city[3] = "Afyonkarahisar";
            //city[4] = "Mersin";

            //Console.WriteLine(city[3]);

            //int[] number = new int[] { 1, 2, 3 };
            //Console.WriteLine(number[1]);


            #endregion

            #region Dizideki Tüm Elemanları Sıralama

            //string[] colors = new string[] { "Beyaz", "Mor", "Kırmızı", "Turuncu", "Mavi", "Yeşil" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char[] chars = { 'a', 'b', 'c', };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] arrayMy = { 112, 100, 6, 8, 44, 65, 88, 102 };
            //int maxNumber = arrayMy[0];
            //for (int i = 0; i < arrayMy.Length; i++)
            //{
            //    if (arrayMy[i] > maxNumber)
            //    {
            //        maxNumber = arrayMy[i];
            //    } 
            //}
            //Console.WriteLine(maxNumber);

            //string[] names = { "ahmet", "Mehmet", "Salih" };
            //Console.WriteLine(names.Length);

            //int[] numbers = { 16, 44, 64, 89, 56, 8, 88, 96 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 16, 44, 64, 89, 56, 8, 88, 96 };
            //Array.Reverse (numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodları

            //string[] customer = { "Ayşe", "Ali", "Ahmet","Mehmet"};
            //int indexNu = Array.IndexOf(customer, "Ahmet");

            //Console.WriteLine(indexNu);
            //int[] numbers = { 16, 44, 56, 86, 8, 41, 78, 99, 999 };
            //Console.WriteLine("En Büyük Numara : " + numbers.Max() + " En Küçük Numara : "+ numbers.Min()); ; ;

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] citys = new string[5];

            //for (int i = 0; i < citys.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}'inci şehri giriniz : ");
            //    citys[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("********************");
            //for (int i = 0;i < citys.Length;i++)
            //{
            //    Console.WriteLine(citys[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
                
            //    if (numbers[i]%2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
              
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.Read();

            
        }
    }
}
