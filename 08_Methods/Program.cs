using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methotlar
            // Geriye değer dönddürmeyen metotolar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Merve YILDIZ");
            //    Console.WriteLine("Kader YILDIZ");
            //    Console.WriteLine("Oya YILDIZ");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //};

            //Sum();
            #endregion

            #region Geriye değer döndürmeyen String parametreli metotlar
            //void yazdir (string name)
            //{
            //    Console.WriteLine(name);
            //};
            //yazdir("Salih");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri Adı ve Soyadı : " + name + " " + surName);
            //}

            //CustomerCard("Ahmet", "YILDIZ");
            #endregion

            #region Geriye değer döndürmeyen int parametreli metodlar
            //void Sum (int number, int number2, int number3) 
            //{ 
            //    int result = number+number2 + number3;
            //    Console.WriteLine(result);

            //}
            //Sum(6, 9, 11);
            #endregion

            #region Geriye değer döndüren metodlar
            //string StudentCard()
            //{
            //    string name = "Ahmet";
            //    string surName = "Çelik";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metodlar
            //string CountryaCard (string Country, string capital,string renk)
            //{
            //    string Card = Country + " " + capital + " " + renk;
            //    return Card;
            //}

            //Console.WriteLine(CountryaCard("Türkiye", "Ankara", "Kırmızı Beyaz"));

            #endregion

            #region Geriye değer döndüren int parametreli metodlar

            //int Toplama(int n, int y, int z)
            //{
            //    int topla = n+y+z;
            //    return topla;
            //}

            //int sayi1, sayi2, sayi3;

            //Console.Write("Bir sayı giriniz : ");
            //sayi1 =  int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz : ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.Write("Son sayı giriniz : ");
            //sayi3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Toplama(sayi1, sayi2,sayi3));
            #endregion

            #region Örnek Uygulama


            //string sinavSonucu (string name, string surName, int sinav1 ,  int sinav2 , int sinav3 )
            //{

            //    int sonuc = (sinav1 + sinav2 + sinav3) / 3;
            //    if ( sonuc >=75 )
            //    {
            //        return ("GEÇTİNİZ");
            //    }
            //    else
            //    {
            //        return ("KALDINIZ");
            //    }
            //}

            //Console.WriteLine(sinavSonucu("Salih", "Koç", 65, 55, 40));


            #endregion

            Console.Read();
        }
    }
}
