// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");

Urunler urun1 = new Urunler();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urunler urun2 = new Urunler();
urun2.Adi = "Çilek";
urun2.Fiyati = 35;
urun2.Aciklama = "Kütür Kütür";

Urunler[] meyveler = new Urunler[] {urun1,urun2  };

foreach (var urun in meyveler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine("----------------");
}
Console.WriteLine("---------Metotlar-------------");
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Karpuz", "Adana Karpuzu", 80);

