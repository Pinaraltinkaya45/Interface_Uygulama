using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çalisan, yazilim, yönetici

            Console.WriteLine("--- Çalişan uygulamamıza hoşgeldiniz ---");
         

            while(true)
            {
                Console.WriteLine("1- Yazilimci İşlemleri ");
                Console.WriteLine("2- Yönetici İşlemleri ");
                Console.WriteLine("Çıkış için q ya basın ");

                Console.WriteLine("Lütfen bir işlem seciniz: ");
                string secilenIslem = Console.ReadLine();

                if (secilenIslem == "q")
                {
                    Console.WriteLine("Programdan Çıkılıyor..");
                    break;
                }
                else if (secilenIslem == "1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "Pınar", "Altınkaya", "java, c#, python,fluter");

                    while (true)
                    {
                        Console.WriteLine("1- Format at");
                        Console.WriteLine("2- Yazilimcinin Bilgilerini Göster");
                        Console.WriteLine("3- Çıkış için q'ye basınız");

                        Console.WriteLine("Yazilimci işlemi seciniz : ");
                        string yazilimci_islem = Console.ReadLine();

                        if (yazilimci_islem == "q")
                        {
                            Console.WriteLine("Yazilimci işlemlerinden çıkış yapılıyor");
                            break;
                        }
                        else if (yazilimci_islem == "1")
                        {
                            Console.WriteLine("İşletim sistemi giriniz: ");
                            string isletim_sistemi = Console.ReadLine();
                            yazilimci.formatAt(isletim_sistemi);
                           
                        }
                        else if (yazilimci_islem == "2")
                        {
                            yazilimci.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz..");
                        }
                    }
                }
                else if(secilenIslem == "2")
                {
                    Yonetici yonetici = new Yonetici(2, "Enes", "Bayram", 12);

                    while(true)
                    {
                        Console.WriteLine("1- Zam yap");
                        Console.WriteLine("2- Yöneticinin bilgilerini göster");
                        Console.WriteLine("3- Çıkış için q ye bas");

                        Console.WriteLine("Yönetici işlemlerini seciniz: ");
                        string yonetici_islem = Console.ReadLine();


                        if ( yonetici_islem == "q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor");
                            break;
                        }
                        else if(yonetici_islem == "1")
                        {
                            Console.Write("Zam Miktarını giriniz: ");
                            int zam_miktari = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zam_miktari);

                        }
                        else if(yonetici_islem=="2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz..");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem giriniz..");
                }
            }

            Console.ReadLine();
        }
    }
}
