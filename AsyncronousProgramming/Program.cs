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
                               //     LiFo      -       Last In First Out
            Stack<string> plate = new Stack<string>();
            plate.Push("First Plate");
            plate.Push("Second Plate");
            plate.Push("Third Plate");

            //foreach (var item in plate)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(plate.Pop());
            // Removes the Last Item
            Console.WriteLine(plate.Peek());
            Console.WriteLine(plate.Peek());
            Console.ReadLine();
        }

        
    }
}
