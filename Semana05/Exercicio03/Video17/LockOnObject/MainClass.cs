using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LockOnObject
{
    class BathrooomStall
    {
        public void BeUsed(int userNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Being used by " + userNumber);
                Thread.Sleep(500);
            }
        }
    }
    public class MainClass
    {
        static BathrooomStall stall = new BathrooomStall();
        static void Main()
        {
            for (int i = 0; i < 3; i++)
                new Thread(RegularUsers).Start();
            new Thread(TheWeirdGuy).Start();

        }   
        static void RegularUsers()
        {
            lock (stall)
                stall.BeUsed(Thread.CurrentThread.ManagedThreadId);
        }
        static void TheWeirdGuy()
        {
            lock (stall)
                stall.BeUsed(99);
        }
    }
}