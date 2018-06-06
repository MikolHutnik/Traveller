using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    class Cruiseline: Traveller
    {
        public Cruiseline()
        {
            
        }

        public string GetCruise()
        {
            switch (base.SwitchValue())
            {
                case 1:
                    RetainValue = "Disney Cruise Line";
                    return RetainValue;

                case 2:
                    RetainValue = "Queen Mary";
                    return RetainValue;

                case 3:
                    RetainValue = "Goodtime3";
                    return RetainValue;

                case 4:
                    RetainValue = "Love Boat";
                    return RetainValue;

                case 5:
                    RetainValue = "Viking";
                    return RetainValue;

                default:
                    RetainValue = "Go Home";
                        return RetainValue;

            }
        }
    }
}
