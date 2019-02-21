using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {

        //Exploring graphs and the breadth-first search


        static Dictionary<string, string[]> graph = new Dictionary<string, string[]>();
        static Queue<string> people = new Queue<string>();
        static Dictionary<string, bool> searched = new Dictionary<string, bool>();

        static void arrayEnqueue(Queue<string> queue, string[] arr)
        {
            foreach (string s in arr)
                people.Enqueue(s);
        }

        static bool person_is_seller (string p)
        {
            if (p == "Thom")
                return true;
            else
                return false;
        }

        static bool breadthFirstSearch()
        {
            
            //breadth-first search
            while (people.Count != 0) //while the queue isn't empty
            {
                string person = people.Dequeue(); //grabs the first person off the queue
                if (!searched.ContainsKey(person)) //If we haven't checked this person already
                {
                    if (person_is_seller(person)) //checks if they're a mango seller
                    {
                        Console.WriteLine(person + " is a mango seller!");
                        return true; //Yes they are
                    }
                    else
                    {
                        Console.WriteLine(person + " is not a mango seller!");
                        arrayEnqueue(people, graph[person]); //No they're not, add their neighbors to the queue
                        searched.Add(person, true); //Add this person to the people that we've searched
                    }
                }
                else 
                    Console.WriteLine("We already checked you " + person);
            }
            Console.WriteLine("There are no mango sellers!");
            return false; //There are no mango sellers in the queue
        }

        static void Main(string[] args)
        {
            //The graph
            //based on: puu.sh/CPipY/42a419604b.jpg
            graph.Add("Me", new string[] { "Alice", "Bob", "Claire" });
            //First-degree contacts
            graph.Add("Alice", new string[] { "Peggy" });
            graph.Add("Bob", new string[] { "Anuj", "Peggy" });
            graph.Add("Claire", new string[] { "Thom", "Jonny" });
            //Second-degree contacts
            graph.Add("Peggy", new string[] { });
            graph.Add("Anuj", new string[] { });
            graph.Add("Thom", new string[] { });
            graph.Add("Jonny", new string[] { });


            arrayEnqueue(people, graph["Me"]);

            breadthFirstSearch();
            Console.ReadLine();
            
            
        }
    }
}
