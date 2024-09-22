using System;
using System.Threading;
class MainClass
{
    static void Main()
    {
        for(int i = 0; i< 8; i++)
        {
        var thread = new Thread(DifferentMethod);
        thread.Start(i);
        }
        

    }
    static void DifferentMethod(object threadID)
    {
        while (true)        
        {
          Console.WriteLine("Dif. Met."+threadID);
        }
        
    }
}