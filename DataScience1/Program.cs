
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Program
    {
        public static int number;
        public static Dictionary<int, Dictionary<int, double>> dictionary;

        static void Main(string[] args)
        {
            dictionary = Dictionary.ReadFile();
            ChooseStrategy();
            
        }
        public static void ChooseStrategy()
        {
            int user1 = Query.ChooseUser(dictionary);

            Console.WriteLine("What Strategy do you want to use? \nPress 1 for Euclidian \nPress 2 for Manhatten \nPress 3 for Pearson \nPress 4 for Cosine");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("you have chosen Euclidian");
                    NearestNeighbour.Calculate(user1, dictionary, new Euclidian());
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You have chosen Manhatten");
                    NearestNeighbour.Calculate(user1, dictionary, new Manhatten());
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You have chosen Pearson");
                    NearestNeighbour.Calculate(user1, dictionary, new Pearson());
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("You have chosen Cosine");
                    NearestNeighbour.Calculate(user1, dictionary, new Cosine());
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You chose something which isn't available. Program will close");
                    Console.ReadLine();
                    break;
            }
        }
    }
}