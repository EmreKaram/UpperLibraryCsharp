using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullation
{
    public class Person
    {
        private string name; //Field: oluşturduğumuz değişkenler.

        public string Name
        {
            get//Get degeri okuyan keyworddur.
            {
                return name;
            }

            set//Set degeri yazan keywroddur.
            {
                name = value;
            }
        }
    }
}
