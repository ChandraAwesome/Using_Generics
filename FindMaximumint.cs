﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximumint
    {
        public static int MaximumNum(int firststvalue, int secondndvalue, int thirdrdvaluve)
        {
            if (firststvalue.CompareTo(secondndvalue) > 0 && firststvalue.CompareTo(thirdrdvaluve) > 0 ||
                firststvalue.CompareTo(secondndvalue) >= 0 && firststvalue.CompareTo(thirdrdvaluve) > 0 ||
                firststvalue.CompareTo(secondndvalue) > 0 && firststvalue.CompareTo(thirdrdvaluve) >= 0)
            {
                return firststvalue;
            }
            if (secondndvalue.CompareTo(firststvalue) > 0 && secondndvalue.CompareTo(thirdrdvaluve) < 0 ||
                secondndvalue.CompareTo(firststvalue) >= 0 && secondndvalue.CompareTo(thirdrdvaluve) > 0 ||
                secondndvalue.CompareTo(firststvalue) > 0 && secondndvalue.CompareTo(thirdrdvaluve) >= 0)
            {
                return secondndvalue;
            }
            if (thirdrdvaluve.CompareTo(firststvalue) > 0 && thirdrdvaluve.CompareTo(secondndvalue) > 0 ||
                thirdrdvaluve.CompareTo(firststvalue) >= 0 && thirdrdvaluve.CompareTo(secondndvalue) > 0 ||
                thirdrdvaluve.CompareTo(firststvalue) > 0 && thirdrdvaluve.CompareTo(secondndvalue) > 0)
            {
                return thirdrdvaluve;
            }
            return firststvalue;
        }
    }
}
