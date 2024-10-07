using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize Notunu Giriniz : ");
            int vize = int.Parse(Console.ReadLine());
            Console.Write("Final Notunu Giriniz : ");
            int final = int.Parse(Console.ReadLine());

            double ortalama = (vize + final) / 2;

            Console.WriteLine("Sınav Ortalaması :" + ortalama);

            if (ortalama > 60)
            {
                Console.WriteLine("Geçti");
            }
            else if (ortalama < 50)
            {
                Console.WriteLine("Kaldı");
            }

            Console.Read();

        }
    }
}
