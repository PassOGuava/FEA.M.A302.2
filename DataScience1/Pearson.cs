using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Pearson : Interface
    {

        
        public double Calculate(Dictionary<int, double> user1, Dictionary<int, double> user2)
        {
            double distance = 0.0;
            double part1 = 0.0;
            double part2 = 0.0;
            double part3 = 0.0;
            double part4 = 0.0;
            double part21 = 0.0;
            double part22 = 0.0;
            double part31 = 0.0;
            double part32 = 0.0;
            double part41 = 0.0;
            double part42 = 0.0;
            double count = 0.0;



            foreach (var item1 in user1)
            {
                foreach (var item2 in user2.Where(x => x.Key == item1.Key))
                {
                    part1 += item1.Value * item2.Value;
                    part21 += item1.Value;
                    part22 += item2.Value;
                    part31 += Math.Pow(item1.Value, 2);
                    part32 += item1.Value; //Has to be squared later on.
                    part41 += Math.Pow(item2.Value, 2);
                    part42 += item2.Value; //Has to be squared later on.
                    count += 1;
                }
            }

            part2 = part21 * part22;
            part3 = Math.Sqrt(part31 - (Math.Pow(part32, 2) / count));
            part4 = Math.Sqrt(part41 - (Math.Pow(part42, 2) / count));

            distance = (part1 - (part2 / count)) / ((part3 * part4));
            
            return distance;
        }
    }
}
