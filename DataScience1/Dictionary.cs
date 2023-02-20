
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Dictionary
    {
        readonly static string path = "../../Data/userItem.data";
        static Dictionary<int, Dictionary<int, double>> dictionary = new Dictionary<int, Dictionary<int,double>>();

        public static Dictionary<int, Dictionary<int, double>> ReadFile()
        {

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    int userID = int.Parse(values[0]);
                    int article = int.Parse(values[1]);
                    double rating = double.Parse(values[2]);

                    FillDictionary(userID, article, rating);
                }
            }
            return dictionary;
        }

        public static Dictionary<int, Dictionary<int, double>> FillDictionary(int userID, int article, double rating)
        {

            if (dictionary.ContainsKey(userID))
            {
                dictionary[userID].Add(article, rating);
            }
            else
            {
                dictionary.Add(userID, new Dictionary<int, double>());
                dictionary[userID].Add(article, rating);
            }
            return dictionary;

        }
        public static void Write()
        {

            foreach (var dictpair in dictionary)
            {
                Console.WriteLine(dictpair.Key);
                foreach (var item in dictpair.Value)
                {
                    Console.WriteLine(" Article: {0} Rating: {1} ", item.Key, item.Value);
                }
                Console.ReadLine();
            }
        }
    }
}