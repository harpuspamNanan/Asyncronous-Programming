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
                // Task helps multi-tasking
            Console.WriteLine("Downloading....");
            ToDownload();
            

            Console.ReadLine();
        }

        static void ToDownload()
        {
            // Run helps making the work pssible in those Sleep operation
            Task.Run( ()=>  {
                Thread.Sleep(2500);
                Console.WriteLine("Completed.");
                }
            );
            
        }
        
    }
}
