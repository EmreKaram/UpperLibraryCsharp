using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Program
    {
        static int Main()
        {
            sinif x = new sinif();

            //Overloading -- Aşırı Yükleme

            Console.WriteLine(Topla(2,3,6));

            Console.ReadLine();
            
            return 0;
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Topla(double a, double b)
        {
            return a + b;
        }

        //Dikkat edilmesi gereken şey şudur: tekrar overloading işlemi yaparken iki tane daha isimleri farklı int değeri tutan bir method oluşturamayız çünkü hali hazırda var. İsimlerinin farklılığı önemsiz.

        static void Yazdir (int a)
        {
            Console.WriteLine(a);
        }

        static void Yazdir(string a)
        {
            Console.WriteLine(a);
        }
    }

    class sinif
    {
        public sinif()
        {
            Console.WriteLine("Birinci");
        }

        public sinif(string yazi)
        {
            Console.WriteLine(yazi);
        }

        public sinif(double sayi)
        {
            Console.Write(sayi);
        }
    }
}
