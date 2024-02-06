using System;
using System.Threading;


class clock
{
    public static void Main()
    {
       
        
        ThreadStart obj=new ThreadStart(time);
        Thread Th=new Thread(obj);
        Th.Start();
    }
    public static void time()
    {
         Console.WriteLine("enter hr");
        int hr=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter min");
        int min=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter sec");
        int sec=Convert.ToInt32(Console.ReadLine());
        for(int i=hr;i<=12;i++)
        {
            
            for(int j=min;j<=59;j++)
            {
              
               if(j==1)
          {
              Console.Beep(32000,1000);
          }
                for(int k=sec;k<=59;k++)
               {
                if(i<10)
                {
                    if(j<10)
                    {
                        if(k<10)
                        {
               Thread.Sleep(1000);
               Console.WriteLine("0{0}:0{1}:0{2}",i,j,k);
                        }
                        else if(k>=10)
                        {
                            Thread.Sleep(1000);
                           Console.WriteLine("0{0}:0{1}:{2}",i,j,k);
                        }
                    }
                    else if(j>=10)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("0{0}:{1}:{2}",i,j,k);
                    }
                }
               
               else if(i>=10)
               {
                   if(j<10)
                   {
                       if(k<10)
                       {
                           Thread.Sleep(1000);
                           Console.WriteLine("{0}:0{1}:0{2}",i,j,k);
                       }
                       else if(k>=10)
                       {
                           Thread.Sleep(1000);
                           Console.WriteLine("0{0}:0{1}:{2}",i,j,k);
                       }
                   }
                   else if(j>=10)
                   {
                       if(k<10)
                       {
                           Thread.Sleep(1000);
                           Console.WriteLine("{0}:{1}:0{2}",i,j,k);
                       }
                       else if(k>=10)
                       {
                           Thread.Sleep(1000);
                           Console.WriteLine("{0}:{1}:{2}",i,j,k);
                       }
                   }
               }
                }
            }
        }   
    }
}
