using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Uygulama
{
    public class Calisan
    {
        private int id;
        private string isim;
        private string soyisim;

        public Calisan(int id,string isim,string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;

        }
        

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getIsim()
        {
            return isim;
        }

        public void setIsim(string isim)
        {
            this.isim=isim;
        }

        public string getSoyisim()
        {
            return soyisim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim=soyisim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("İd: " + this.id);
            Console.WriteLine("İsim: " + this.isim);
            Console.WriteLine("Soyisim: " + this.soyisim);
        }

    }
}
