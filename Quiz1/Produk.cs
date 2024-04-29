using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    internal class Produk
    {
        public string barang { get; set; }
        public double harga { get; set; }
        public int stock { get; set; }

        public Produk(string barang, double harga, int stock)
        {
            this.barang = barang;
            this.harga = harga;
            this.stock = stock;
        }
    }
}
