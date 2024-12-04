using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Uygulama
{
    public class Yonetici : Calisan
    {
        private int sorumluKisiSayisi;
        public Yonetici(int id,string isim,string soyisim, int sorumluKisiSayisi) : base(id, isim, soyisim)
        {
            
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine(getIsim() + " " + zamMiktari + "TL çalişanlara zam yapti..");
        }

    }
}
