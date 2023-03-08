using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullation
{
    public class Class1
    {
        private string name;

        public string Name
        {
            get //Eğer sadecce get tanımlarsak değeri readonly yapmış oluruz.
            {
                return name;
            }

            set//Eğer sadece set tanımlarsak bu seferde konsol da yazdırmak mümkün olmayacaktır. Ancak değer atıyabiliriz.
            {
                name = value;
            }
        }
    }
}
