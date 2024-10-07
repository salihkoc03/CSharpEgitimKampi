using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine("");
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district , city;

            //customerName = "Salih";
            //customerSurname = "Koç";
            //customerEmail = "koc@gmail.com";
            //customerPhone = "+9 500 400 30 30" ;
            //district = "Şuhut";
            //city = "Afyon";


            //Console.WriteLine("**** Rezervasyon Kartları ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri" +" " + customerName +" "+ customerSurname);
            //Console.WriteLine("İletişim" + " " + customerPhone);
            //Console.WriteLine("Email Adresi" + " " + customerEmail);
            //Console.WriteLine("Adres" + " " + district + "/" + city);
            //Console.WriteLine("------------------------------");


            //Console.WriteLine("");

            //customerName = "Şule";
            //customerSurname = "Koç";
            //customerEmail = "sule@gmail.com";
            //customerPhone = "+9 500 400 70 80";
            //district = "Büyükkalecik";
            //city = "Afyon";

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri" + " " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim" + " " + customerPhone);
            //Console.WriteLine("Email Adresi" + " " + customerEmail);
            //Console.WriteLine("Adres" + " " + district + "/" + city);
            //Console.WriteLine("------------------------------");


            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokeprice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzasPrice = 250;
            int lemondePrice = 30;
            

            Console.WriteLine("***** Restorant Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger : " + " " + hamburgerPrice + " " + "TL");
            Console.WriteLine("Kola :" + " " + cokeprice + " " + "TL");
            Console.WriteLine("Kızartma :" + " " + friesPrice + " " + "TL");
            Console.WriteLine("Su :" + " " + waterPrice + " " + "TL");
            Console.WriteLine("Pizza :" + " " + pizzasPrice + " " + "TL");
            Console.WriteLine("Limonata :" + " " + lemondePrice + " " + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restorant Menü Fiyatı *****");
          

            #endregion
            Console.ReadKey();
        }
    }
}
