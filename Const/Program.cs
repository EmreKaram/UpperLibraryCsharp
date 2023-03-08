using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    public class Program
    {
        const double PI = 3.14;

        static int Main()
        {
            //Const sabit demektir.

            //PI = 2.71; Bu şekilde bunu değiştiremeyiz çünkü sabit bir değer olarak belirttim.

            Console.WriteLine(PI);

            Console.ReadLine();

            return 0;
        }
    }
}
