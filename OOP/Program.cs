using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static int Main()
        {
            Kisi birinciKisi = new Kisi
            {
                Ad = "Ahmet",
                Soyad = "Kaplan",
                Yas = 18
            };

            birinciKisi.Ozellikler();

            Console.ReadLine();

            return 0;
        }
    }
}
