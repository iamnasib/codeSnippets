using System;
class car
{
    public static void Main()
    {
        int command=0;
        string choice="yes";
        while(choice=="yes")
        {
         Console.WriteLine("Enter the command");
         string com=Console.ReadLine();
         if(com=="start")
        {
         if(command==1)
         {
             Console.WriteLine("Car already Started");
             
         }
         else
         {
         Console.WriteLine("Car  Started");
         command=1;
         }
         
        }
        else if (com=="stop")
        {
            if(command==0)
            {
            Console.WriteLine("Car already stopped");
            }
            else
            {
                command=0;
                Console.WriteLine("car stopped");
            }
        }
        else if (com=="exit")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid command");
        }
        }
    }

}