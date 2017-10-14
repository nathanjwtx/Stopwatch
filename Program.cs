using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Stopwatch
{
    static class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            var key = "";

            while (running)
            {
                var watch = new Stopwatch();
                Console.WriteLine("starting");
                while (running)
                {
                    Console.WriteLine("Press S to start stopwatch and X to stop or Z to exit");
                    var action = Console.ReadLine();
                    switch (action)
                    {
                        case "s":
                            if (key != "s")
                            {
                                key = "s";
                                watch.StartClock();
                            }
                            else
                            {
                                Console.WriteLine("Crash: already running");
                                running = false;
                            }
                            break;
                        case "x":
                            Console.WriteLine(watch.StopClock());
                            key = "x";
                            break;
                        default:
                            Console.WriteLine("Toodle pip!");
                            running = false;
                            break;
                    }
                }
            }
        }
    }
}
