using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_Algorithms
{
    class Program
    {
        /*
           Set-covering problem:

           Suppose you’re starting a radio show. You want to reach listeners in all 50 states.You have to decide what
           stations to play on to reach all those listeners. It costs money to be on each station, so you’re trying to minimize the
           number of stations you play on.You have a list of stations. Each station covers a region, and there’s overlap.

           How do you figure out the smallest set of stations you can play on to cover all 50 states?
       */

        //A hashset is a datastructure which cannot have duplicates.
        static Dictionary<String, HashSet<string>> stations = new Dictionary<string, HashSet<string>>();
        static HashSet<string> final_stations = new HashSet<string>();
        
        static void Main(string[] args)
        {
            stations.Add("kone", new HashSet<string> { "id", "nv", "ut" });
            stations.Add("ktwo", new HashSet<string> { "wa", "id", "mt" });
            stations.Add("kthree", new HashSet<string> { "or", "nv", "ca" });
            stations.Add("kfour", new HashSet<string> { "nv", "ut" });
            stations.Add("kfive", new HashSet<string> { "ca", "az" });

            HashSet<string> states_needed = new HashSet<string>() {"mt", "wa", "or", "id", "nv", "ut", "ca", "az" };   
            string best_station = "";
            IEnumerable<string> states_covered = new HashSet<string>();
            HashSet<string> states_for_station = new HashSet<string>();
            while (states_needed.Count > 0)
            {
                foreach (KeyValuePair<string, HashSet<string>> s in stations)
                {
                    IEnumerable<string> covered = states_needed.Intersect(s.Value);
                    if (covered.Count() > states_covered.Count())
                    {
                        best_station = s.Key;
                        states_covered = covered;
                    }
                }
                foreach (string s in states_covered.ToList())
                    states_needed.Remove(s);
                final_stations.Add(best_station);
            }
            
            

            foreach (string s in final_stations)
                Console.WriteLine(s + " ");
            Console.ReadLine();
        }
    }
}
