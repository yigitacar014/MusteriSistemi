// See https://aka.ms/new-console-template for more information
//string=sözel int tam sayı double kesirli sayı bool önermeler
string proje = "projeler";
int ProjeSayisi = 15;
double FaizOrani = 1.45;
bool SistemeGirisYaptıMi = false;
double dolarDun = 26.06;
double dolarBugun = 26.06;
if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("artış butonu");
}
else
{
    Console.WriteLine("Eşittir butonu");
}
if (SistemeGirisYaptıMi==true)
{
    Console.WriteLine("Sistemde");
}
else
{
    Console.WriteLine("Sistemde değil");
}

