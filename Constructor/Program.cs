using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Program
    {
        static int Main()
        {
            Kisi2 birinciKisi = new Kisi2("XYZ","ABC");

            Kisi2 ikinciKisi = new Kisi2();

            ikinciKisi._Ad = "xyz";
            ikinciKisi._Soyad = "abc";

            birinciKisi.BilgiYazdir();
            Console.WriteLine("--------");
            ikinciKisi.BilgiYazdir();

            Console.ReadLine();

            return 0;
        }
    }
}
