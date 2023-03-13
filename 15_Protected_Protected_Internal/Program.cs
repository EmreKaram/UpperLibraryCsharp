using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Protected_Protected_Internal
{
    public class Program
    {
        static void Main()
        {
            B nesne = new B();
            nesne.y = 8;
            Console.ReadLine();
        }
    }

    class A : B
    {
        public void Yaz()
        {
            x = 1;
        }
    }

    class B
    {
        protected int x; //Protected kendisinden tanımlanmış classlarda kullanılabilir. Türetilmiş class A B den türemiştir.
        protected internal int y; //Protetcted Internal ise hem kendinden türetilmiş class da hemde ınternal gibi aynı projede kullanılabilir.
    }

}
