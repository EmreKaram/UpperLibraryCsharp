using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    public class Program
    {
        static void Main()
        {
            A nesne = new A(6,7,78);
            Console.WriteLine(nesne.x);
            Console.WriteLine(nesne.y);
            Console.WriteLine(nesne.z);

            Console.ReadLine();
        }
    }

    class A
    {
        public int x;

        public int y;

        public int z;

        public A(int x)
        {
            this.x = x;
        }

        public A(int x, int y, int z) : this(x)
        {
            this.y = y;
            this.z = z;
            //Burada görüldüğü gibi x i tanımlamadık onun yerine this(x) diyip A classından işlem yaptık.
        }
    }

}
