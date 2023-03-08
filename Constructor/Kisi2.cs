using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Kisi2
    {
        public string _Ad;
        public string _Soyad;

        //Constructor Method
        public Kisi2(string ad, string soyad)
        {
            _Ad = ad;
            _Soyad = soyad;
        }

        public Kisi2()
        {

        }

        public void BilgiYazdir()
        {
            Console.WriteLine(_Ad + " " + _Soyad);
        }
    }
}
