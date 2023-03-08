using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace DLR_IronPython
{
    public class Program
    {
        static int Main()
        {
            //NuGet den IronPython'u indiriyoruz.
            //using IronPython.Hosting; kodunu namespace den once yaziyoruz.

            var source = @"C:\Users\Emre\Desktop\Code\Python\DynamicIron.py";

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var operation = engine.Operations;

            engine.ExecuteFile(source, scope);

            var Hesap = scope.GetVariable("Hesap");
            dynamic ins = operation.CreateInstance(Hesap);
            //ornek bir dynamic kullanimi.
            //Burada python uzerinden yazdigimiz bir kodu c# uzerinden calistiriyoruz.

            /* Python Kodu:
                     class Hesap():
            def __init__(self):
                pass

            def topla(self,x,y):
                return(x+y)
    
            def fark(self,x,y):
                return(x-y)

            Buradi python kodunu direkt var source seklinde tanimlayabiliriz'de.
             */ 

            Console.WriteLine(ins.topla(15, 20));

            Console.ReadLine();

            return 0;
        }
    }
}
