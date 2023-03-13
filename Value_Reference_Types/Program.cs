using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Reference_Types
{
    public class Program
    {
        static void Main()
        {
            //Stack Heap
            //Değer Tip--int,float,double,unit,struct
            //Referans Tip--class,object,array,interface,delegate,string(chart array)

            int x; //Değer tipidir Stack'de tutulur.
            float y; //Değer tipidir Stack'de tutulur.

            int myVar = 5;

            int a = 12;

            int[] dizi = { 5, -19 };

            Console.WriteLine(a);

            Degistir(a); //Bu işlem yapıldıktan sonra 

            Console.WriteLine(a); //Burada 5 yazılmasını bekleriz ancak iş öyle olmaz ve 12 yazılır.
            //Nedeni int'ın bir değer tipi olmasıdır. Değer tipine parametreler verilirken değeri kopyalanarak verirlir.

            MyClass refType = new MyClass();

            MyClass nesne = new MyClass(); //nesne ismi stack'de tutuldu ve heap'de bir tane alan işaret edildi.

            Console.WriteLine(dizi[0] + " " + dizi[1]);
            degistir(dizi);
            Console.WriteLine(dizi[0] + " " + dizi[1]); //Burada ise beklendiği üzere değerler değişti.
            //Değişme sebebi ise array(dizi)lerin referans tipi olmasıdır.

            MyClass2 refType2 = new MyClass2();
            refType2.myVar1 = 5;
            Console.WriteLine(refType2.myVar1); //5
            _degistir(refType2);
            Console.WriteLine(refType2.myVar1); //19

            Console.ReadLine();
        }
        static void _degistir(MyClass2 a)
        {
            a.myVar1 = 19;
        }
        static void Degistir(int x)
        {
            x = 5;
        }
        static void degistir(int[] x)
        {
            x[0] = 8;
            x[1] = 15;
        }
    }
    class MyClass
    {
        int myVar;
    }
    class MyClass2
    {
        public int myVar1;
    }
}
