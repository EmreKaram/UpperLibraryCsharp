using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ProductInfos//Base Class Not:Önce base classın consturactoru çalışır.
    {
        public string productName { get; set; }
        public string productPrice{ get; set; }
        public int productQuantity { get; set; }

        public ProductInfos()
        {
            Console.WriteLine("ProductInfos");
        }
    }
}
