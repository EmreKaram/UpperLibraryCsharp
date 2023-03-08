using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cok_Boyutlu_Diziler
{
    public class Program
    {
        static int Main()
        {
            int[,,] dizi = { { { 2, 6 }, { 4, 9 }, { 8, -9 } }, { { 16, -9 }, { 32, -9 }, { 64, -9 } } };

            //index sayarken ilki her zaman 0 dır!
            //burda 1 yazdığım için görünürdeki 2. listeyi alıyorum.

            Console.WriteLine(dizi[1,2,1]);

            Console.ReadLine();

            return 0;
        }
    }
}
