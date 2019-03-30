using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncronousProgramming
{
    class Stack
    {

        static void Main(string[] args)
        {
            var myHash = new HashSet<string>();         // Reomves Redundancy from the data

            myHash.Add("hi");
            myHash.Add("hi");
            string[] s = new string[] { "hi" };
            Console.WriteLine(myHash.Count );
            Console.WriteLine(myHash.Overlaps(s));      // Overlaps checks if the input from another field has similarity or not

            Console.ReadLine();
        }

        
    }
}
