using System;
using System.Collections.Generic;

namespace inrapp
{
    
    public class Pair
    {
        public int Key;
        public string Value;

        public Pair(int key, string value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"({Key}, {Value})";
        }
    }

    public class Solution
    {
        
        public List<List<Pair>> InsertionSort(List<Pair> pairs)
        {
            int n = pairs.Count;
            List<List<Pair>> res = new List<List<Pair>>();  

            
            for (int i = 1; i < n; i++)
            {
                Pair keyPair = pairs[i]; 
                int j = i - 1;

                
                while (j >= 0 && pairs[j].Key > keyPair.Key)
                {
                    pairs[j + 1] = pairs[j];
                    j--;
                }

                
                pairs[j + 1] = keyPair;

                
                List<Pair> cloneList = new List<Pair>(pairs);
                res.Add(cloneList);
            }
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Pair> pairs = new List<Pair>
            {
                new Pair(8, "Vanilla"),
                new Pair(4, "Chocolate"),
                new Pair(10, "Mocha"),
                new Pair(3, "Rocky Road"),
                new Pair(11, "Cookies n Cream")
            };

            Solution solution = new Solution();
            List<List<Pair>> sortedStates = solution.InsertionSort(pairs);

            
            Console.WriteLine("List after each insertion:");
            foreach (var state in sortedStates)
            {
                Console.WriteLine(string.Join(", ", state));
            }
        }
    }
}
