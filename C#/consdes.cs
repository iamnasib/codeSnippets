using System;
class cons
{
    int g;
     int x=20;
    public static void Main()
    {
    try{
       Console.WriteLine("Enter number");
       int num = Convert.ToInt32(Console.ReadLine());
       int res=15/num;
       Console.WriteLine(num);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
        cons obj=new cons();
        obj.abc();
        obj.xyz();
    }
    public void abc()
    {
        Console.WriteLine("abc "+g);
    }
     public void xyz()
     {
        Console.WriteLine("xyz "+g);
     }
    public cons()
    {
        g=x;
        Console.WriteLine("constructer called");
    }
    ~cons()
    {
        Console.WriteLine("destruction");
    }

}