using System;
class p1
{
    public static void Main()
    {
        string[] username=new string[3];
        username[0]="iamnasib";
        username[1]="vicky123";
        username[2]="iyad123";
        string[] pswrd=new string[3];
        pswrd[0]="nasib12";
        pswrd[1]="vicky12";
        pswrd[2]="iyad12";
        Console.WriteLine("Enter your username");
        string user=Console.ReadLine();
        Console.WriteLine("Enter your password");
        string password=Console.ReadLine();
        if(user==username[0] && password==pswrd[0] || user==username[1] && password==pswrd[1] || user==username[2] && password==pswrd[2])
        {
            Console.WriteLine("Welcome");
        }
        else 
        {
            Console.WriteLine("Incorrect username or password");
        }
    }
}