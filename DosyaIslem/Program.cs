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
        public string Ad { get { return ad; } set{ad=value; }}
        public string Soyad { get{return soyad; } set {soyad=value; } }
    }

    class Meslek : Ekleme
    {
        public string meslek;
        public Meslek(string meslek)
        {
            this.meslek = meslek;
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ekleme ek = new Ekleme();
            ek.Sayi = 1;
            ek.Ad = "Alican";
            ek.Soyad = "Baydar";

            //Her çalıştırıldığında Dosyaad isimli dosyaya yeniden yazılma amacıyla file.createtext
            //Dosya yolu değiştirilip çalıştırılabilir
            string dosyayolu1 = @"C:\Users\Atakan\Desktop\Dosyaad.txt";
            StreamWriter dosyaadi = File.CreateText(dosyayolu1);
            Console.WriteLine("Alican Baydar için meslek giriniz! ");
            string meslek1 = Console.ReadLine();
            dosyaadi.WriteLine(ek.Sayi +" "+ ek.Ad +" "+ ek.Soyad +".  Meslek: "+ meslek1);
            dosyaadi.Close();
            Console.WriteLine("1.Dosyaya bilgiler yazıldı");

            //Her seferinde Dosyaad1 dosyası üzerine yazılması amacıyla
            Ekleme ek1 = new Ekleme { Sayi = 3, Ad = "Aylin", Soyad = "Saygın" };
            string dosyayolu2 = @"C:\Users\Atakan\Desktop\Dosyaad1.txt";
            StreamWriter dosyaadi1 = new StreamWriter(dosyayolu2, true);
            dosyaadi1.WriteLine(ek1.Sayi +" " + ek1.Ad +" " + ek1.Soyad);
            Console.WriteLine("2.Dosya için 1. kişinin verileri girildi");
            
            Meslek mslk = new Meslek("Doktor");
            mslk.Sayi = 2;
            mslk.Ad = "Hakan";
            mslk.Soyad = "Uygun";
  
            dosyaadi1.WriteLine(mslk.Sayi +" "  + mslk.Ad +" "+ mslk.Soyad +". " + "Meslek: "+ mslk.meslek);
            dosyaadi1.Close();
            Console.WriteLine("2.Dosyadaki 2.kişinin verileri girildi \n");
            
            //Dosya okuma işlemleri..
            StreamReader oku = new StreamReader(dosyayolu1);
            string okunan = oku.ReadToEnd();
            Console.WriteLine("1.Dosya okundu! Bilgiler: "+ okunan);

            StreamReader oku2 = new StreamReader(dosyayolu2);
            string okunan2 = oku2.ReadToEnd();
            Console.WriteLine("2.Dosya Okundu! Bilgiler: \n" + okunan2);
        }
    }
}