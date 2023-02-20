
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Manhatten : Interface
    {

        public double Calculate(Dictionary<int, double> user1, Dictionary<int, double> user2) {
            double distance = 0.0;
            double calculatedDistance = 0.0;

            foreach (var item1 in user1)
        {
            foreach (var item2 in user2.Where(x => x.Key == item1.Key))
            {
                distance += Math.Abs(item1.Value - item2.Value);
            }
        }
        calculatedDistance = 1 / (1 + distance);
        return calculatedDistance;
        }
    }
}