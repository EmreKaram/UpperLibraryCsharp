using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Ornek
{
    public class Program
    {
        //Enum lar kodu daha okunulabilir yapar.
        static int Main()
        {
            string[] schools = Enum.GetNames(typeof(Schools));

            foreach (string school in schools)
            {
                Console.WriteLine(school);
            }
            //Burada bütün değerlerimizi yazdırıyoruz.

            foreach (var item in Enum.GetValues(typeof(Schools)))
            {
                Console.WriteLine(item);
            }
            //Aynı görevi yaıyor.
            
            Console.WriteLine(Schools.PrimarySchool.ToString("d"));
            //Index döndürmek için başka bir yol. D veya d kullanılabilir.

            Person person = new Person();
            person.school = Schools.University.ToString();

            if (person.school.Equals(Schools.PrimarySchool.ToString()))
            {
                Console.Write("XYZ");
            }

            else if (person.school.Equals(Schools.HighSchool.ToString()))
            {
                Console.WriteLine("ABC");
            }

            else if (person.school.Equals(Schools.University.ToString()))
            {
                Console.WriteLine("123");
            }

            Console.WriteLine((int)Schools.PrimarySchool == 1);

            Console.WriteLine(typeof(Program));

            Console.WriteLine(Enum.Parse(typeof(Schools),"PrimarySchool"));
            //direk ismi yazmak yerine "1" şeklinde index de yazılabilir. Eğer index karşılığı olmaya bir index verirsek sayının kendisini verir. Ornek olarak 100 indexine karşılık gelecek bir stringimiz yok bu durumda konsol bize yazdığımı index sayısını geri döndürecek.


            Console.ReadLine();

            return 0;
        }
    }

    enum Schools
    {
        PrimarySchool = 1,
        HighSchool,
        University
        //PrimarySchool = 1 olarak tanımlasam index 0 dan değil birdden başlar ve geri kalan da ona uyacak şekilde index değiştirir. Hepsine kendimde değer tanımlayabilirim.
    }

    class Person
    {
        public Person()
        {
            school = Schools.HighSchool.ToString();
        }

        public string school;
    }
}
