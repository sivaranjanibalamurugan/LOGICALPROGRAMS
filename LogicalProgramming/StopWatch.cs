using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class StopWatch
    {
        
        public static void ReadInput()
        {
          

            //creating object for class stopwatch
            StopWatch StopWatch = new StopWatch();
            Console.WriteLine("Enter 1 to start the stopwatch and 0 to stop the stopwatch:");

            //read inpt from user
            int choice = Convert.ToInt32(Console.ReadLine());
            int iter = choice;

            //to run stop watch for particular period of time 
            while (iter == 1)
            {
                switch (choice)
                {
                    case 1:
                        StopWatch.Start();
                        break;
                    case 0:
                        StopWatch.Stop();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("enter 0 to stop or 1 to continue");
                iter = Convert.ToInt32(Console.ReadLine());
            }

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = StopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }


    }
}
    

