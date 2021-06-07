using System;
using System.IO;
namespace DosyaIslem
{
    class Ekleme
    {
        private int sayi;
        private string ad;
        private string soyad;
        public int Sayi { get {return sayi; } set {sayi=value; } }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ekleme ek = new Ekleme();
            ek.Sayi = 1;
            ek.Ad = "alican";
            ek.Soyad = "baydar";

            StreamWriter dosyaadi = File.CreateText(@"C:\Users\Atakan\Desktop\Dosyaad.txt");
            dosyaadi.WriteLine("asdasdasdasd");
            dosyaadi.WriteLine("xsxdxd");
            dosyaadi.WriteLine(ek.Sayi + ek.Ad + ek.Soyad);
            dosyaadi.Close();

            StreamWriter dosyaadi2 = new StreamWriter(@"C:\Users\Atakan\Desktop\Dosyaad2.txt",true);
            dosyaadi2.WriteLine("yeniler");
            dosyaadi2.Close();
        }
    }
}