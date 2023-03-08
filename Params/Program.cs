using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    public class Program
    {
        static int Main()
        {
            //Params parametreler demektir.

            Console.WriteLine(Topla(2, 3, 1, 5 ,1 ,2 ,3 ,4 ,1 ,7 ,3 , 12));

            //Oluşturduğum methodu çağırıp içine int türünde istediğim kadar değer giriyorum ve yazdırıyorum.
            //Çok boyutlu bir dizi kullanamazsınız.

            Console.ReadLine();

            return 0;
        }

        static int Topla(params int[] sayilar) //Burda parametre olarak int tutacağımı, bu parametrelerin dizi olacağını, oluşturduğum bu parametrelerin(params) isminin sayilar olacağını belirttim.

            //Bir methoda birden fazla params kullanamazsınız.
        {
            int toplam = 0; //Başlangıç değeri 0 olan toplam adında ve int türünde bir değer belirtiyorum.

            foreach (var item in sayilar) //Sayiları döndürüyorum.
            {
                toplam += item;
                //Dönerken ise toplam (0) değerine gelecek olan item leri (itemleri sayilar dan alıyoruz) ekletiyorum. 
            }
            return toplam; //Return edilirken ise en son ki toplamı veriyorum.
        }

    }
}
