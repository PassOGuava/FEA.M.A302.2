using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Euclidian : Interface
    {
         
        public double Calculate(Dictionary<int, double> user1, Dictionary<int, double> user2) {
            double distance = 0.0;
            double calculatedDistance = 0.0;

            foreach (var item1 in user1)
            {
                foreach (var item2 in user2.Where(x => x.Key == item1.Key))
                {
                    distance += Math.Pow((item1.Value - item2.Value),2);
                }
            }
            calculatedDistance = 1 / (1 + Math.Sqrt(distance));
            return calculatedDistance;
        }

    }
}
