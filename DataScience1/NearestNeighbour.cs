using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class NearestNeighbour
    {
        private static double sim;
        private static double threshold = 0.35;
        private static List<double> nearneighbour = new List<double>();

        public static void Calculate(int targetuser, Dictionary<int, Dictionary<int, double>> dictionary, Interface algo)
        {


            foreach (var item in dictionary)
            {
                if (item.Key != targetuser)
                {
                    Console.WriteLine(targetuser);
                    double sim = algo.Calculate(dictionary[targetuser], item.Value);
                    if (sim > threshold)
                    {
                        if (nearneighbour.Count() < 3)
                        {
                            nearneighbour.Add(sim);
                            nearneighbour.Sort();
                            nearneighbour.Reverse();
                        }
                        else
                        {
                            if (nearneighbour[2] < sim)
                            {
                                nearneighbour.RemoveAt(2);
                                nearneighbour.Add(sim);
                            }
                        }

                    }
                    

                }

            }
            nearneighbour.Sort();
            nearneighbour.Reverse();
            foreach (var item in nearneighbour)
            {
                Console.WriteLine(item);
            }


        }
    }
}
