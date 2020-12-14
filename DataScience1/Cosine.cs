
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Cosine : Interface
    {
        
        public double Calculate(Dictionary<int, double> user1, Dictionary<int, double> user2)
        {
            double distance = 0.0;
            double part1 = 0.0;
            double part2 = 0.0;
            double part3 = 0.0;
            double numerator = 0.0;
            double denumerator = 0.0;

            foreach (var item in user1)
            {
                if (!user2.ContainsKey(item.Key))
                {
                    user2.Add(item.Key, 0.0);
                }
            }

            foreach (var item in user2)
            {
                if (!user1.ContainsKey(item.Key))
                {
                    user1.Add(item.Key, 0.0);
                }
            }



            foreach (var item1 in user1)
            {
                foreach (var item2 in user2.Where(x => x.Key == item1.Key))
                {
                    part2 += Math.Pow(item1.Value, 2);
                    part1 += (item1.Value * item2.Value);
                    part3 += Math.Pow(item2.Value, 2);
                }
            }


            numerator = part1;
            denumerator = Math.Sqrt(part2) * Math.Sqrt(part3);
            distance = numerator / denumerator;


            return distance;
        }
    }
}