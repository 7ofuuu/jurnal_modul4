using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300043
{
    internal class KodeProduk
    {
        public String produkElektronik;
        public String kodeProduk;

        public KodeProduk(String produkElektronik, String kodeProduk)
        {
            this.produkElektronik = produkElektronik;
            this.kodeProduk = kodeProduk;
        } 

        public String getKodeProduk()
        {
            return kodeProduk;
        }
    }
}
