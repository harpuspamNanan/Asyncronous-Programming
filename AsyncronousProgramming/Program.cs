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
            DownloadFromRealWebsite();         

            Console.ReadLine();
        }

        static async Task ToDownloadAsync()
        {
            await Network.ToDownload();
            Console.WriteLine("Completed");               
        }

        static async void DownloadFromRealWebsite()
        {
            HttpClient client = new HttpClient();
            var data =  await client.GetStringAsync("https://github.com/hps3103?tab=repositories");
            Console.WriteLine("\nDownload Completed." + data);
        }
        
    }

    class Network
    {
        static public Task ToDownload()
        {
            return Task.Run(() => {
                Thread.Sleep(2500);                
            });
        }
    }
}
