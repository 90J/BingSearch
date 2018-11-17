using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;



namespace SearchBing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This will net about 5$ per month in MS rewards points when set up with Task Scheduler
             * Be signed in to MS account in Internet Explorer
             * In Task Scheduler set this run run daily as a specified time. 
             * At level 2 you accrue 150 points per day for 30 days
             * 150 * 30 = 4500
             * 5$ Amazon card costs 5250.
             * An extra 100 points per day can be gotten from 10 quick searches on Mobile using the Bing App for a gain of 3000 points in the month
             * 7500 points per month.
            */

            //Create list of search terms, maybe later grab search terms from text file
            List<string> searchTerms = new List<string>()
            {
                //search terms can be anything, but must be unique, repaeting the same search over and over does nothing beyond the initial points given
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
                "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
            };

            //foreach through the list
            foreach (string search in searchTerms)
            {
                //do the search
                Process.Start(@"C:\Windows\WinSxS\wow64_microsoft-windows-i..etexplorer-optional_31bf3856ad364e35_11.0.17134.1_none_bc7d0ddbb62acd90\iexplore.exe", "\"? " + search + "\"");
                //had to put a delay in, otherwise some searches would be skipped. 60% skip rate
                Thread.Sleep(1000);
            }

            //kill all the open windows when finished
            foreach (var process in Process.GetProcessesByName("iexplore"))
            {
                process.Kill();
            }
        }
    }
}
