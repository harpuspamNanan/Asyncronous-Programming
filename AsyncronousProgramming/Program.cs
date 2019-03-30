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
            bool[] preload = new bool[3] { true, true, false };
            BitArray enemyGrid = new BitArray(preload);
            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
           
            //enemyGrid[0] = false;
            //enemyGrid[1] = true;
            //enemyGrid.Set(2, false);        // Just another way to store a value


        }

        
    }
}
