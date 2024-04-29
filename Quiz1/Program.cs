using Quiz1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static ProdukManager manager = new ProdukManager();
    static Autentikasi auth = new Autentikasi();

    static void Main(string[] args)
    {
        Console.WriteLine("Selamat Datang di Toko");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (auth.Login(username, password))
        {
            Console.WriteLine("Login Berhasil");
            ShowMenu();
        }
        else
        {
            Console.WriteLine("Username atau password salah");
        }
    }

    static void TambahProduk()
    {
        Console.WriteLine("Masukkan nama Produk: ");
        string namaBarang = Console.ReadLine();
        Console.WriteLine("Masukkan harga Produk: ");
        double harga = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan jumlah Produk: ");
        int stock = Convert.ToInt32(Console.ReadLine());

        manager.tambahProduk(namaBarang, harga, stock);
    }
    
    static void HapusProduk()
    {
        Console.WriteLine("Masukkan nama produk yang akan dihapus: ");
        string namaBarang = Console.ReadLine();
        manager.hapusProduk(namaBarang);
    }

    static void SearchbyName()
    {
        Console.WriteLine("Masukkan nama produk: ");
        string namaBarang = Console.ReadLine();
        manager.SearchByNama(namaBarang);
    }

    static void SearchbyHarga()
    {
        Console.WriteLine("Masukkan Harga Minimum: ");
        double minHarga = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan Harga Maksimum: ");
        double maxHarga = Convert.ToDouble(Console.ReadLine());
        manager.SearchByHarga(minHarga, maxHarga);
    }

    static void DisplayAllProducts()
    {
        manager.DisplayAllProducts();
    }


    static void ShowMenu()
    {
        int option = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Cari Produk Berdasarkan Nama");
            Console.WriteLine("4. Cari Produk Berdasarkan Rentang Harga");
            Console.WriteLine("5. Urutkan Produk Berdasarkan Stok");
            Console.WriteLine("6. Tampilkan Produk");
            Console.WriteLine("7. Keluar");
            Console.Write("Pilih opsi: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    TambahProduk();
                    break;

                case 2:
                    HapusProduk(); 
                    break;
                
                case 3:
                    SearchbyName();
                    break;

                case 4:
                    SearchbyHarga();
                    break;

                case 5:
                    manager.SortByStock();
                    break;

                case 6:
                    DisplayAllProducts();
                    break;
                case 7:
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi ini");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Tidak Valid");
                    break;
            }
        }
        while (option != 0);
    }
}