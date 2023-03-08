using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Object_Dynamics
{
    public class Program
    {
        static int Main()
        {
            /* 
            Var
            Object
            Dynamic
            */

            int a = 5;
            string b = "ahmet";

            var c = 10;
            var d = "mehmet";

            //Burada var degerlerin tipini algilayip deger turune ceviriyor. (Fare imleci ile var yazisinin ustune gelince gorunuyor.)

            int e = 15;
            string f = "ayse";

            object g = 20;
            object h = "emre";

            //Burada object degerleri object olarak turuyor.

            //int turunde gozuken g'yi int turunden bir degere esitlemek icin:

            int i = (int)g; //(int) ile unboxin islemi yapmak lazim.

            dynamic x = 5;
            dynamic y = "dynamic";

            string z = y; //Goruldugu uzere herhangi bir unboxing islemi yapilmasina gerek yok. Ancak dynamic olsa bile unboxing islemi onerilir.

            //Dynamic ile Object arasinda fark ne ?

            dynamic kelime = "Merhaba";
            object kelime2 = "Selam";
                
            string u = kelime;

            //Console.WriteLine(u.Length); Calisan kod.

            //kelime.Yazdir(); Yazdir adinda bir methodum olmamasina ragmen derleyici herhangi bir hata vermiyor. Runtime da hata meydana geliyor
            //kelime2.Yazdir(); Burada ise editor hata veriyor runtime a gecmeden hata veriyor.

            //Dynamic nerede kullanilir.
            //Statik ve dinamik diller arasinda bir koprudur.
            

            Console.ReadLine();

            return 0;
        }
        
        
    }
}
