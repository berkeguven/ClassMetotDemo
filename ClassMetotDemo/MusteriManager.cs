using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Ad + " " + musteri.Soyadi);
        }

        public void Listele( Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine( musteri.Id + " " + musteri.Ad + " " + musteri.Soyadi + " " + musteri.Yas);

            }
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Ad + " " + musteri.Soyadi);
        }

    }
}
