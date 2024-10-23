using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**** C# Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("*********************************************");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("1-Ürünler");
            Console.WriteLine("1-Siparişler");
            Console.WriteLine("1-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz");
            tableNumber = Console.ReadLine();
            Console.WriteLine("*********************************************");

            SqlConnection connection = new SqlConnection("Data Source=SALIH\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From tbl_Category",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); // Köprü görevi görecek
            DataTable dataTable = new DataTable(); // Verileri belleğe almamı sağlayacak
            adapter.Fill(dataTable); 
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
