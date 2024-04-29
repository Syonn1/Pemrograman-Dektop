using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    internal class ProdukManager
    {
        private List<Produk> listProduk = new List<Produk>();

        public void tambahProduk(string namaBarang, double harga, int stock)
        {
            listProduk.Add(new Produk(namaBarang, harga, stock));
            Console.WriteLine("Produk berhasil ditambahkan.");
        }

        public void hapusProduk(string namaBarang)
        {
            var produk = listProduk.FirstOrDefault(p => p.barang.ToLower() == namaBarang.ToLower());
            if(produk != null)
            {
                listProduk.Remove(produk);
                Console.WriteLine("Produk berhasil dihapus");
            }
            else
            {
                Console.WriteLine("Produk tidak ada.");
            }
        }

        private void DisplayProduk (IEnumerable<Produk> listProduk)
        {
            if (listProduk.Any())
            {
                Console.WriteLine("{0,-20} {1,-10} {2,-5}", "Nama Produk", "Harga", "Stok");
                foreach (var produk in listProduk)
                {
                    Console.WriteLine("{0,-20} {1,-10} {2,-5}", produk.barang, produk.harga.ToString("C"), produk.stock);
                }
            }
                
        }

        public void DisplayAllProducts()
        {
            Console.WriteLine("Daftar Semua Produk:");
            DisplayProduk(listProduk);
        }

        public void SearchByNama (string namaBarang)
        {
            var filterProduk = listProduk.Where(p => p.barang.ToLower().Contains(namaBarang.ToLower()));
            DisplayProduk(filterProduk);
        }

        public void SearchByHarga (double minHarga, double maxHarga)
        {
            var filterProduk = listProduk.Where(p => p.harga >= minHarga && p.harga <= maxHarga);
            DisplayProduk (filterProduk);
        }

        public void SortByStock()
        {
            var sortProduk = listProduk.OrderBy(p => p.stock);
            DisplayProduk(sortProduk);
        }
    }
}
