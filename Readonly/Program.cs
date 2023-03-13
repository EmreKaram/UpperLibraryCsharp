using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly
{
    public class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass(3.14);

            Console.WriteLine(MyClass.PI);

            Console.WriteLine(myClass.PI2);

            Console.WriteLine(myClass.PI3);

            Console.ReadLine();
        }

        class MyClass
        {
            public const double PI = 3.14;
            //Const lar class seviyesinde tanımlanabilir.
            public readonly double PI2 = 3.14;
            //Readonly de okuyabilmek için nesne oluşturmamız lazım.
            //Readonly nin constdan avantajı değeri ilk başta girmek zorunda olmamamızdır yani;
            public readonly double PI3; //Şeklinde yapılabilir.

            public MyClass(double x)
            {
                PI3 = x;
            }

            //Ancak ikisinde de aynı olan şey tanımlandıktan sonra değerini değiştiremezsiniz.
        }

    }
}
