using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("title", "Website");
            var s = (String)table["title"];         // Accessing it through Unboxing
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
