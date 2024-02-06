using System;
using System.Threading;


class threadstart
{
    public static void Main()
    {
        
        ThreadStart obj=new ThreadStart(fun);
        Thread Th=new Thread(obj);
        
        Console.WriteLine("MAIN");
        Th.Start();
        Thread.Sleep(1000);
        Console.WriteLine("MAIN AGAIN");

    }
    public static void fun()
    {
        for(int i=0;i<=10;i++)
        {
            Console.WriteLine(i);
           
            
          Thread.Sleep(1000);
           
          if(i==5)
          {
              Console.Beep(1000,1000);
          }
        }
        
    }
}