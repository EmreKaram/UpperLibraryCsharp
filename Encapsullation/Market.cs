using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullation
{
    public class Market
    {
        private string cost;

        public string Cost
        {
            get 
            {
                return cost; 
            }

            set 
            {
                if (value == "0TL")
                {
                    cost = "FREE";
                }

                else
                {
                    cost = value;
                }
            }
        }

    }
}
