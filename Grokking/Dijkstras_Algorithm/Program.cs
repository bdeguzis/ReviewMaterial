using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstras_Algorithm
{
    class Program
    {

        static Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>();
        static Dictionary<string, int> costs = new Dictionary<string, int>();
        static Dictionary<string, string> parents = new Dictionary<string, string>();
        static Dictionary<string, bool> processed = new Dictionary<string, bool>();
        

        static KeyValuePair<string, int> findLowestCostNode(Dictionary<string, int> costs)
        {
            KeyValuePair<string, int> lowestCostNode = new KeyValuePair<string, int>();
            int lowestCost = int.MaxValue;

            foreach (KeyValuePair<string, int> node in costs)
            {
                int cost = costs[node.Key];
                if (cost < lowestCost && (!processed.ContainsKey(node.Key)))
                {
                    lowestCost = cost;
                    lowestCostNode = node;
                }
            }

            return lowestCostNode;
        }


        static void Main(string[] args)
        {
            //Setting up the graph
            graph.Add("start", new Dictionary<string, int>());
            graph["start"].Add("a", 6);
            graph["start"].Add("b", 2);
            graph.Add("a", new Dictionary<string, int>());
            graph["a"].Add("fin", 1);
            graph.Add("b", new Dictionary<string, int>());
            graph["b"].Add("a", 3);
            graph["b"].Add("fin", 5);
            graph.Add("fin", new Dictionary<string, int>());

            int infinity = int.MaxValue;
            costs.Add("a", 6);
            costs.Add("b", 2);
            costs.Add("fin", infinity);

            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("fin", "");

            //Dijkstra's Algorithm
            KeyValuePair<string, int> node = findLowestCostNode(costs);
            while (node.Key != null)
            {
                int cost = costs[node.Key];
                Dictionary<string, int> neighbors = new Dictionary<string, int>();
                foreach (KeyValuePair<string, int> n in graph[node.Key])
                {
                    neighbors.Add(n.Key, n.Value);
                }
                foreach (KeyValuePair<string, int> s in neighbors)
                {
                    int newCost = cost + neighbors[s.Key];
                    if (costs[s.Key] > newCost)
                    {
                        costs[s.Key] = newCost;
                        parents[s.Key] = node.Key;
                    }
                }
                processed.Add(node.Key, true);
                node = findLowestCostNode(costs);

            }

            foreach (KeyValuePair<string, string> n in parents)
            {
                Console.Write("Node: " + n.Key + " | " + "Parent: " + n.Value + "\n");
            }
            Console.ReadLine();




            //----Extra problems----

            //1. Path = Start -> A -> D -> Finish Cost: 8

            //graph.Add("start", new Dictionary<string, int>());
            //graph["start"].Add("a", 5);
            //graph["start"].Add("c", 2);
            //graph.Add("a", new Dictionary<string, int>());
            //graph["a"].Add("d", 2);
            //graph["a"].Add("b", 4);
            //graph.Add("b", new Dictionary<string, int>());
            //graph["b"].Add("fin", 3);
            //graph["b"].Add("d", 6);
            //graph.Add("c", new Dictionary<string, int>());
            //graph["c"].Add("a", 8);
            //graph["c"].Add("d", 7);
            //graph.Add("d", new Dictionary<string, int>());
            //graph["d"].Add("fin", 1);
            //graph.Add("fin", new Dictionary<string, int>());

            //int infinity = int.MaxValue;
            //costs.Add("a", 5);
            //costs.Add("c", 2);
            //costs.Add("b", infinity);
            //costs.Add("d", infinity);
            //costs.Add("fin", infinity);

            //parents.Add("a", "start");
            //parents.Add("c", "start");
            //parents.Add("b", "");
            //parents.Add("d", "");
            //parents.Add("fin", "");

            //2. Path: Start -> A -> B -> Finish Cost: 60
            //graph.Add("start", new Dictionary<string, int>());
            //graph["start"].Add("a", 10);
            //graph.Add("a", new Dictionary<string, int>());
            //graph["a"].Add("b", 20);
            //graph.Add("b", new Dictionary<string, int>());
            //graph["b"].Add("fin", 30);
            //graph["b"].Add("c", 1);
            //graph.Add("c", new Dictionary<string, int>());
            //graph["c"].Add("a", 1);
            //graph.Add("fin", new Dictionary<string, int>());

            //int infinity = int.MaxValue;
            //costs.Add("a", 10);
            //costs.Add("b", infinity);           
            //costs.Add("c", infinity);
            //costs.Add("fin", infinity);

            //parents.Add("a", "start");
            //parents.Add("c", "");
            //parents.Add("b", "");
            //parents.Add("fin", "");


        }
    }
}
