using System;
class condition
{
    public static void Main()
    {
        string u1="nasib";
        string u2="burhan";
        string u3="mohsin";
        string u4="athar";
        Console.WriteLine("Enter your username");
        string user=Console.ReadLine();
        if (user == u1 || user == u2 || user == u3 || user == u4)
        {
            Console.WriteLine("Welcome "+ user);
        }
        else
        {
             Console.WriteLine("Username not found "+ user);
        }
    }
}        

        