// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;



Musteri musteri = new Musteri();
musteri.musteriAdi = "Mehmet";
musteri.musteriSoyadi = "Akkoyun";
musteri.Yası = 34;

Musteri musteri1= new Musteri();

musteri1.musteriAdi = "Yiğit";
musteri1.musteriSoyadi = "Açar";
musteri1.Yası = 19;

Musteri musteri2= new Musteri();
musteri2.musteriAdi = "Miray";
musteri2.musteriSoyadi = "Korkmaz";
musteri2.Yası = 38;

Musteri[] musteriler = new Musteri []{ musteri, musteri1, musteri2 };
foreach (var musteri45 in musteriler)
{
    Console.WriteLine(musteri45.musteriAdi);
    Console.WriteLine(musteri45.musteriSoyadi);
    Console.WriteLine(musteri45.Yası);

}
Musteriekle musteriekle = new Musteriekle ();
musteriekle.MusteriEkle(musteri);
musteriekle.MusteriEkle(musteri1);
musteriekle.MusteriEkle(musteri2);





