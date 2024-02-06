using System;
class fullnam
{
    public static void Main()
    {
        
        Console.WriteLine("Enter your first name");
        string user=Console.ReadLine();
        Console.WriteLine("Enter your second name");
        string user1=Console.ReadLine();
        fullnam obj=new fullnam();
        string z=obj.display(user,user1);
        Console.WriteLine(z);
       
        
    }
    public string display(string user,string user1)
    {
       string fullname=user+user1;
        return fullname;
    }
}