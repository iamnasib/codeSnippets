using System;
class account
{
    public static void Main()
    {
        
        Console.WriteLine("Enter username");
        string user=Console.ReadLine();
        if (user=="athar")
        {
            Console.WriteLine("Welcome " + user);
            Console.WriteLine("Enter the amount you want to add");
            int amt=Convert.ToInt32(Console.ReadLine());
            account athar=new account();
            athar.balance(amt);
           
        }
        else
        {
          Console.WriteLine("Invalid user");
        }
        
    }
    public void balance(int amt)
    {
        int bal1=50000;
        int total=bal1+amt;
        Console.WriteLine("Total balance " + total);
    }
}