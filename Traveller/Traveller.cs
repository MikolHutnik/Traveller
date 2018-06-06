using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    class Traveller
    {


        public Traveller()
        {
            //Default constructor
        }

        public int Age { get; set; }
        public int Value { get; set; }
        public string RetainValue { get; set; }

        public int SwitchValue()
        {
            if (Age == 30)
            {
                return 1;
            }

            else if (Age == 31)
            {
                return 2;
            }

            else if (Age == 32)
            {
                return 3;
            }

            else if (Age == 33)
            {
                return 4;
            }
            else if (Age == 34)
            {
                return 5;
            }

            else
            {
                return 0;
            }
        }

        //public int TravConvert(int age)
        //{
        //    switch (Age)
        //    {
        //        case 1:


        //            break;
        //        default:
        //            break;

        //    }
        //    return Age;

        //}
    }//class end
}//namespace end
