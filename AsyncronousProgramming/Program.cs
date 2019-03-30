using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            // Using Lambda Function
            Network.ToDownload( ()=> Console.WriteLine("\nDownload Completed" ));
        }



    }

    class Network
    {
        static public Task ToDownload(Action callback) // Action treats it as a delegate
        {
            return Task.Run(() => {
                Thread.Sleep(2500);
                callback();
            });
        }
    }
}
