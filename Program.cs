using System;
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
                Console.WriteLine("Press S to start stopwatch and X to stop or Z to exit");
                var action = Console.ReadLine();
                var watch = new Stopwatch();
                switch (action)
                {
                    case "s":
                        if (key != "s")
                        {
                            key = "s";
                            watch.StartStopwatch();
                        }
                        else
                        {
                            throw new InvalidOperationException("Already running");
                        }
                        break;
                    case "x":
                        if (key != "x")
                        {
                            key = "x";
                            Console.WriteLine(watch.Stop);
                        }
                        break;
                    default:
                    {
                        Console.WriteLine("Exit stopwatch");
                        running = false;
                        break;
                    }
                }
            }
        }
    }
}
