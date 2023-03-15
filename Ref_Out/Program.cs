using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    public class Program
    {
        //static public int y { get; set; } //ref ve out prop olarak kullanılamaz.

        //static public int y;

        static void Main()
        {
            int y;

            int x = 5;

            Console.WriteLine(x);

            degistir(ref x);

            Console.WriteLine(x);

            Console.WriteLine(bol(19,5,out y));

            Console.WriteLine(y);

            Console.ReadLine();
        }

        static void degistir(ref int param) //Ref - Out 
        {
            param = 30;
        }

        //ref ve out un kullanımı aynıdır.
        //ref de ilk deger olması mecburidir yani
        //ref int y; şeklinde tanımlayamayız.
        //out da ise durum öyle değildir.
        //out int y; şeklinde tanımlanabilir.

        static int bol(int bolunen, int bolen, out int kalan)
        {
            int bolum = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                if (bolunen > bolen)
                {
                    bolunen -= bolen;
                    bolum++;
                }
                else
                {
                    break;
                }
            }

            kalan = bolunen;

            return bolum;
        }
    }
}
