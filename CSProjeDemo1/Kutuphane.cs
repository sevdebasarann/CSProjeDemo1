using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<IUye> Uyeler { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<IUye>();
        }

        public void KitapDurumGuncelle(Kitap kitap, Durum durum)
        {
            kitap.Durum = durum;
        }

        public void KutuphaneDurumunuGoruntule()
        {
            Console.WriteLine("Kütüphane Durumu:");
            Console.WriteLine($"Mevcut Kitaplar: {Kitaplar.Count}");
            Console.WriteLine($"Üye Sayısı: {Uyeler.Count}");
        }
    }
}
