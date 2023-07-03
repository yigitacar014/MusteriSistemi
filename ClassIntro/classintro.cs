// See https://aka.ms/new-console-template for more information


string adi = "Yigidov";
int yas = 18;
string ders = "Proglamlama";

Ders ders1 = new Ders();
ders1.OgretmenAdi = "Yigidov";
ders1.DersAdi="Proglamlama";
ders1.Yası = 18;

Ders ders2 = new Ders();
ders2.OgretmenAdi = "Merto";
ders2.DersAdi = "Bilişim";
ders2.Yası = 22;


Ders ders3 = new Ders();
ders3.OgretmenAdi = "Müniş";
ders3.DersAdi = "Etik";
ders3.Yası = 38;

Console.WriteLine(ders1.OgretmenAdi + ":" + ders1.DersAdi);

Ders[] dersler= new Ders[] { ders1, ders2 ,ders3  };
foreach (var x in dersler)
{
    Console.WriteLine(x.DersAdi + ":" x.OgretmenAdi);
}
class Ders
{
    public string DersAdi { get; set; }
    public string OgretmenAdi  { get; set; }
    public int Yası { get; set; }
}

