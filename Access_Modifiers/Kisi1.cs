using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Kisi1
    {
        //Public, Private, Internal, Protected, Protected Internal

        //Public = Heryeden ulaşılabilir.
        //Private = Gizli olur ve sadece tanımlandığı class da ulaşılabilir.
        //Internal = Aynı programda ulaşılabilir ancak başka bir programdan ulaşılamaz. 

        public string Ad;
        internal string Soyad;
        private int Yas;

    }
}
