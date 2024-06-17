using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine($"Main Thread ID: {Thread.CurrentThread.ManagedThreadId}");

        var tasks = new[]
        {
            RunTask("Task 1"),
            RunTask("Task 2"),
            RunTask("Task 3")
        };

        await Task.WhenAll(tasks);
    }

    static async Task RunTask(string taskName)
    {
        Console.WriteLine($"{taskName} - Started - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(1000);
        Console.WriteLine($"{taskName} - Resumed - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
}
