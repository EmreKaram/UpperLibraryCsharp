using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Base
{
    public class Program
    {
        static void Main()
        {
            A nesne = new A();

            //İlk base classın consturactoru çalıştırılır. Yani B !

            Console.ReadLine();
        }
    }

    class A : B
    {
        public A() : base(5) //Yaz
        {
            //Yaz(); Burada A classının yazı çalışıyor. Method Overloading.
            //base.Yaz(); //Burada ise base classımızın (B Classı) Yaz methodu çalışıyor.
            Console.WriteLine("A");
        }

        public A(int x) : base(x)
        {
            Console.WriteLine("A " + x);
        }

    }

    class B
    {
        public B() //Yaz
        {
            Console.WriteLine("B");
        }

        public B(int y)
        {
            Console.WriteLine("B " + y);
        }

    }

}
