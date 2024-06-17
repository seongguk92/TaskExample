using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    #region example1

    //static async Task Main(string[] args)
    //{
    //    Console.WriteLine($"Main Thread ID: {Thread.CurrentThread.ManagedThreadId}");

    //    var tasks = new[]
    //    {
    //        RunTask("Task 1"),
    //        RunTask("Task 2"),
    //        RunTask("Task 3")
    //    };

    //    await Task.WhenAll(tasks);
    //}

    //static async Task RunTask(string taskName)
    //{
    //    Console.WriteLine($"{taskName} - Started - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    //    await Task.Delay(1000);
    //    Console.WriteLine($"{taskName} - Resumed - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    //}

    #endregion

    #region example2

    static async Task Main(string[] args)
    {
        Console.WriteLine($"Main Thread ID: {Thread.CurrentThread.ManagedThreadId}");

        Task taskA = RunTask("Task A");
        await taskA.ConfigureAwait(false);  // ConfigureAwait(false)를 사용하여 스레드 변경 가능성을 명시적으로 표시

        Console.WriteLine($"Main Thread ID after await: {Thread.CurrentThread.ManagedThreadId}");
    }

    static async Task RunTask(string taskName)
    {
        Console.WriteLine($"{taskName} - Started - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(1000).ConfigureAwait(false);
        Console.WriteLine($"{taskName} - Resumed - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }

    #endregion

}
