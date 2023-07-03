using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Dortislem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç :" + toplam);
        }
        public void Cıkart(int sayi3,int sayi4)
        {
            int cıkarma = sayi3 - sayi4;
            Console.WriteLine("Sonuç :"+ cıkarma);
        }
       public void Carp(int sayi5, int sayi6)
        {
            int carpma= sayi5 * sayi6;
            Console.WriteLine("Sonuç :" + carpma);
        }
        public void Bol(double sayi7 , double sayi8 )
        {
            double bolme = sayi7 / sayi8;
            Console.WriteLine("Sonuç:" + bolme );
        }
    }
}
