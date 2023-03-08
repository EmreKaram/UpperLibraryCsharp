using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Listeler
{
    public class Program
    {
        static int Main()
        {
            int[] sayilar = new int[3] {2,6,7};
            //yukarıdaki diziye eleman sayımın 3 olacağını belirttim bundan dolayı 3 eleman yerinde 4 elemamn yazarsam derleyici hata verir.

            List<int> numbers = new List<int>() { 2,6,7,8,-15};
            //Listelerde ise durum tam tersi istediğim kadar yazabilirim.

            numbers.Add(19);
            numbers.Add(-7);
            //Eğer oluşturduğum listeye yeni şey ler eklemek istersem liste_adı.Add(eklemek_istediğim_değer) i yazmam yeterli.

            numbers.Add(11);

            numbers.Remove(11);
            //Listeye eklediğim değeri listeden kaldırmak içinn Remove methodunu çağrıyorum.
            numbers.RemoveAt(3);
            //RemoveAt methodu ise değeri index türünden kaldırıyor yani listede belirttiğim 4. değer.

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //Esktradann eklediğim değerleri konsola yazdırmak için foreach döngüsünü kullanıyorum.

            Console.WriteLine(numbers.Count + "\n");
            //Listenin eleman sayısı yazdırıyorum.

            Console.WriteLine(numbers.Contains(7)+"\n");
            //Liste 7'yi içeriyormu.

            Console.WriteLine(numbers.BinarySearch(7)+"\n");
            //Listede 7 nin index değeri nedir bu durumda 2'dir.
            List<int> newNumber = new List<int>(sayilar);

            foreach (var item in newNumber)
            {
                Console.WriteLine(item);
            }

            //Burada ise sayfanın en başında oluşturduğum dizi yi liste ye çeviriyorum.

            Console.WriteLine(newNumber[2]);
            //Burda dizi deki istediğim indexi yazdırıyorum.

            Console.ReadLine();

            return 0;
        }
    }
}
