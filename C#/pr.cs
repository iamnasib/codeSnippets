using System;
class condition
{
    public static void Main()
    {
        string u1="nasib";
        string u2="burhan";
        string u3="mohsin";
        string u4="athar";
        string p4="athar123";
        string p1="nasib123";
        string p2="vicky123";
        string p3="mohsin123";
        Console.WriteLine("Enter your username");
        string user=Console.ReadLine();
         Console.WriteLine("Enter your password");
            string pswrd=Console.ReadLine();
        if (user == u1 && pswrd==p1 || user == u2 && pswrd==p2 || user == u3 && pswrd==p3 || user == u4 && pswrd==p4)
        {
          
                Console.WriteLine("WELCOME " +user);

            }
           

        
        else
        {
             Console.WriteLine("Incorrect username or password ");
        }
    }
}        

        