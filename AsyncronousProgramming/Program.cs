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
    class Program
    {

        static void Main(string[] args)
        {
            // Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "Hello", true);

           var a = Tuple.Create(1, "Create", true);
           Console.WriteLine(a.Item2);



           Console.ReadLine();
        }

        
    }
}
