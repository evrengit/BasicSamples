using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            used for super fast lookup.
            Items are uniq
            Items order is not important
            */
          
            List<string> list = new List<string>() { "cat", "dog", "hat", "just", "hat", "cat" };
            HashSet<string> hashSet = new HashSet<string>(list);

            // Add an object to the set
            hashSet.Add("cat");

            // Remove an object 
            hashSet.Remove("just");

            // Remove all objects 
            hashSet.Clear();

            // Check to see if the set contains an object 
            var contains = hashSet.Contains("dog");

            Console.WriteLine(String.Join(",", hashSet));
            Console.ReadLine();

        }
    }
}
