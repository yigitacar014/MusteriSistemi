// See https://aka.ms/new-console-template for more information

string ders1 = "Sosyoloji";
string ders2 = "Psikoloji";
string ders3 = "Matematik";

string[] dersler = new string[] { "Sosyoloji", "Psikoloji", "Matematik","Türkçe" };

for (int i = 0; i < dersler.Length; i ++)
{
    Console.WriteLine(dersler[i]);
}
Console.WriteLine("for bitti");
foreach (string ders in dersler)
{
    Console.WriteLine(ders);
}


