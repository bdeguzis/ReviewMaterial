using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static Dictionary<string, long> phonebook = new Dictionary<string, long>();
        static Dictionary<string, Boolean> voters = new Dictionary<string, bool>();
        static long getNumber(string name)
        {
            return phonebook[name];
        }

        static void addPerson (string name, long num)
        {
            phonebook.Add(name, num);
        }

        static void checkVoter (string name)
        {
            if (voters.ContainsKey(name))
                Console.WriteLine("kick them out");
            else
                Console.WriteLine("let them vote");

        }

        static void Main(string[] args)
        {

            //Dictionary<string, double> book = new Dictionary<string, double>();

            //book.Add("apple", 0.67);
            //book.Add("milk", 1.49);
            //book.Add("avocado", 1.49);

            //Console.WriteLine(book["apple"]);
            //Console.ReadLine();

            //Hashtable book2 = new Hashtable();
            //book2.Add("first", 1);
            //book2.Add(2, "two");
            //book2.Add(3.2, book);

            //Console.WriteLine(book2[2]);
            //Console.ReadLine();

            //addPerson("Mary", 6780348881);
            //addPerson("Bob", 5559995555);
            //addPerson("Joe", 3331119999);
            //addPerson("Police", 911);

            //Console.WriteLine(getNumber("Mary"));
            //Console.WriteLine(getNumber("Bob"));
            //Console.WriteLine(getNumber("Joe"));
            //Console.WriteLine(getNumber("Police"));

            //Console.ReadLine();

            voters.Add("bob", true);

            checkVoter("bob");
            checkVoter("tim");
            voters.Add("tim", true);
            checkVoter("tim");

            Console.ReadLine();

        }
    }
}
