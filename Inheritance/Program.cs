using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main()
        {
            Computer Asus = new Computer();
            Asus.RAM = "16";
            Asus.CPU = "AMD RYZEN 5000 SERIES 7";
            Asus.productPrice = "30000";
            Asus.productQuantity = 35;
            Asus.productName = "Asus Zephyrus";

            Asus.WriteInfos();

            Console.ReadLine();
        }
    }
}
