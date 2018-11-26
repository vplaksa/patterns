using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PatternsConsole
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int worker;
    //        int ioCompleteon;
    //        ThreadPool.GetMaxThreads(out worker, out ioCompleteon);

    //        Console.WriteLine(worker); //32767
    //        Console.WriteLine(ioCompleteon); //100
    //        Console.WriteLine("Hello World!");
    //        Console.Read();
    //    }
    //}
    //class Program
    //{
    //    static void DummyCall()
    //    {
    //        Thread.Sleep(1000000000);
    //    }

    //    static void Main(string[] args)
    //    {
    //        int count = 0;
    //        var threadList = new List<Thread>();
    //        try
    //        {
    //            while (true)
    //            {
    //                Thread newThread = new Thread(new ThreadStart(DummyCall), 1024);
    //                newThread.Start();
    //                threadList.Add(newThread);
    //                count++;
    //                if(count%1000 == 0)
    //                    Console.WriteLine(count);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Max" +  count);
    //        }
    //    }
    //}


    class Program
    {
        private static async Task<int> Sleep(int ms)
        {
            Console.WriteLine("Sleeping for " + ms);
            var task = Task.Run(() => Thread.Sleep(ms));
            await task;
            Console.WriteLine("Sleeping for " + ms + "END");
            return ms;
        }

        static async void Main(string[] args)
        {
            Console.WriteLine("Starting");

            Console.WriteLine("Sleeping for " + 2000);
            var task1 = Task.Run(() => Thread.Sleep(2000));

            Console.WriteLine("Sleeping for " + 2000 + "END");


            Console.WriteLine("Sleeping for " + 1000);
            var task2 = Task.Run(() => Thread.Sleep(1000));
            await task2;
            Console.WriteLine("Sleeping for " + 1000 + "END");

            int totalSlept = t1.Result + task2.Result;

            Console.WriteLine("Slept for " + totalSlept + " ms");
            Console.ReadKey();
        }
    }


}
