using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullation
{
    public class Program
    {
        static void Main()
        {
            //Encapsullation da bilgilerimizi kapsüllüyoruz ve esas propuma dışardan erişimi (private) ile engelliyoruz.
            Person pr = new Person();
            Market mr = new Market();
            Class1 c = new Class1();

            pr.Name = "XYZ";
            mr.Cost = "0TL";
            c.Name = "asdas";
            
            Console.WriteLine(pr.Name);
            Console.WriteLine(mr.Cost);
            Console.WriteLine(c.Name);

            Console.ReadLine();
        }
    }
}
