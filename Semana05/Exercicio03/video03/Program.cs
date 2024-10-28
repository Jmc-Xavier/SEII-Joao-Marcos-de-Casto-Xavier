﻿using System;
using System.Threading;
class MainClass
{
    static int count = 0;
    static void Main()
    {
        var thread1 =new Thread(IncrementCount);
        var thread2 = new Thread(IncrementCount);
        thread1.Start();
        Thread.Sleep(500);
        thread2.Start();  

    }
    static void IncrementCount()
    {
      while(true)
      {
        count=count+1;
        Console.WriteLine("Thread ID" + Thread.CurrentThread.ManagedThreadId+"Incremented count to "+count);
        Thread.Sleep(1000);
      }   
    }
}