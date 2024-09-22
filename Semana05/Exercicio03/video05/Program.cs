using System;
using System.Threading;
class MainClass
{
    static object baton = new object();
    static Random rand = new Random ();
    static void Main()
    {
        for ( int i = 0; i<50; i++)
        {
            new Thread(useRestroomStall).Start();
        }
    }
    static void useRestroomStall()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Trying to obtain the bathroom stall...");
        lock (baton)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " obtained the lock. Doing my business ");
            Thread.Sleep(rand.Next(2000));
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Leaving the stall");

        }
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " is leaving the restaurant" );

    }
}