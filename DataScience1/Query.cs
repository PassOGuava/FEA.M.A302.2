using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Query
    {
        private static int selecteduser;
        private static Dictionary<int, double> otheruser = new Dictionary<int, double>();
        public static int ChooseUser(Dictionary<int, Dictionary<int, double>> dictionary) {
            Console.WriteLine("Choose user");
            selecteduser = int.Parse(Console.ReadLine());
            //var user = dictionary[selecteduser];

            //foreach (var item in user)
            //{
            //    Console.WriteLine("article: " + item.Key + " rating: " + item.Value);
            //}
            return selecteduser;
        }
    }
}
