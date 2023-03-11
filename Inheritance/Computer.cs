using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Computer : ProductInfos //Miras alma işlemi ProductInfos daki bilgiler Computerda da kullanılabilir. Kalıtılmış class Dericed Class olarak geçer.
    {
        public string CPU { get; set; }
        public string RAM { get; set; }  
        
        public void WriteInfos()
        {
            Console.WriteLine(RAM);
            Console.WriteLine(CPU); 
            Console.WriteLine(productName);
            Console.WriteLine(productQuantity);
            Console.WriteLine(productPrice);
        }

        public Computer()
        {
            Console.WriteLine("Computer");
        }
    }
}
