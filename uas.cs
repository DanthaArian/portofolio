using System;
using System.Collections.Generic;

public class Program
{
    static List<Dictionary<string, object>> produkList = new List<Dictionary<string, object>>();

    public static void Main()
    {
        tambah_produk("P001", "Lemari Pendingin", "Elektronik", 5);
        tambah_produk("P002", "Air Conditioner", "Elektronik", 10);
        tambah_produk("P003", "Smartwatch", "Gadget", 15);
        tambah_produk("P004", "Smartphone", "Gadget", 20);

        daftar_produk();

        Console.WriteLine("\nMemperbarui produk dengan kode P003...");
        perbarui_produk("P003", "Smartwatch Pro", "Gadget", 25);

        daftar_produk();
    }

    static void tambah_produk(string kode, string nama, string kategori, int stok)
    {
        var produkBaru = new Dictionary<string, object>
        {
            {"kode", kode},
            {"nama", nama},
            {"kategori", kategori},
            {"stok", stok}
        };
        produkList.Add(produkBaru);
        Console.WriteLine($"Produk {nama} berhasil ditambahkan.");
    }

    static void daftar_produk()
    {
        Console.WriteLine("\nDaftar Produk:");
        foreach (var produk in produkList)
        {
            Console.WriteLine($"Kode: {produk["kode"]}, Nama: {produk["nama"]}, Kategori: {produk["kategori"]}, Stok: {produk["stok"]}");
        }
    }

    static void perbarui_produk(string kode, string nama_baru, string kategori_baru, int stok_baru)
    {
        foreach (var produk in produkList)
        {
            if (produk["kode"].ToString() == kode)
            {
                produk["nama"] = nama_baru;
                produk["kategori"] = kategori_baru;
                produk["stok"] = stok_baru;
                Console.WriteLine($"Produk dengan kode {kode} berhasil diperbarui.");
                return;
            }
        }
        Console.WriteLine($"Produk dengan kode {kode} tidak ditemukan.");
    }
}

// M Dantha Arianvasya
// NIM 1237050106