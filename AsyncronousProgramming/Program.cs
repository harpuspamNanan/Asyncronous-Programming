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
            //     FiFo      -       First In First Out
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);         // Insertion
            myQueue.Enqueue(3);

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myQueue.Dequeue());  // MOves to the First Item and Remove it
            Console.WriteLine(myQueue.Peek());

            Console.ReadLine();
        }

        
    }
}
