using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Berke";
            musteri1.Soyadi = "Güven";
            musteri1.Yas = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyadi = "Kaya";
            musteri2.Yas = 29;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ayşe";
            musteri3.Soyadi = "Yılmaz";
            musteri3.Yas = 24;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("----------------------------");

            musteriManager.Listele(musteriler);

            Console.WriteLine("----------------------------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

            Console.ReadLine();
            

        }
    }
}
