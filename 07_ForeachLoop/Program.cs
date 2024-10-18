using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "Ankara", "İstanbul", "Afyon", "Adana", "Kocaeli", "Mersin" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //foreach (int i in number)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //int total = 0;
            //foreach (int numbers in number)
            //{
            //    total += numbers;

            //}
            //Console.WriteLine(total);
            #endregion

            //List<string> list = new List<string>()
            //{
            //    "Ahmet","Mehmet","Salih"
            //};

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //string name = "Salih";
            //foreach (char i in name)
            //{
            //    Console.WriteLine(i);
            //}

            #region Öğrenci Sınav Sistemi Proğramı
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğtenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler

            string[] studentsName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}'nci öğrencinin adını giriniz : ");
                studentsName[i] = Console.ReadLine();

                double totalExampResult = 0;

                // Her öğrenci için sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsName[i]} isimli öğrencinin {j+1}'nci sınav notonu giriniz : ");
                    double value = int.Parse(Console.ReadLine());
                    totalExampResult += value; // Notları topluyoruz
                }
                Console.WriteLine();
                Console.WriteLine();

                studentExamAvg[i] = totalExampResult / 3;
            }
            // Sınav Ortalamaları
            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentsName[i]} isimli öğrencinin ortalaması :  {studentExamAvg[i]}");

               
                // Öğrencilerin ortalaması ve geçip kalma durumları 

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentsName[i]} isimli öğrenci sınavı GEÇTİ");
                }
                else 
                {
                    Console.WriteLine($"{studentsName[i]} isimli öğrenci sınavdan KALDI");
                }
                Console.WriteLine("------------------------------");
            }





            #endregion



            Console.ReadKey();
        }
    }
}
